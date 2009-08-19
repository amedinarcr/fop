using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Voltage
{
    public partial class UC_DataGridCharting : UserControl
    {
        public DataTable CollectDataTable;
        public DataSet oneCollectDataSet;
        public bool isDetail = false;
        public UC_DataGridCharting()
        {
            InitializeComponent();
            this.dataTree1.grid = this;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void ShowData(string CollectIdList)
        {
            string querySql = "Select * from DataTable where CollectInfoId in "+CollectIdList+" order by DataTime desc";
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, querySql);
            this.oneCollectDataSet = ds;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Columns["DataValue"].DefaultCellStyle.Format = "F3";
            this.dataGridView1.Columns["DataTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            this.dataGridView1.Columns["DataId"].Visible = false;
            this.dataGridView1.Columns["CollectInfoId"].Visible = false;
            this.isDetail = true;
        }
        private void UC_DataGridCharting_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowHeadersWidth = 18;
            Thread task = new Thread(new ThreadStart(this.ShowAllCollectInfo));
            task.Start();
        }
        public void ShowCharting(DataSet ds)
        {
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "CollectInfo.CollectId":
                    e.Column.HeaderText = "采集器编号";
                    break;
                case "CollectId":
                    e.Column.HeaderText = "采集器编号";
                    break;
                case "DataTime":
                    e.Column.HeaderText = "采集时间";
                    break;
                case "DataValue":
                    e.Column.HeaderText = "电位值";
                    break;
                case "ProtectStationName":
                    e.Column.HeaderText = "保护站名称";
                    break;
                case "TestPileID":
                    e.Column.HeaderText = "测试桩编号";
                    break;
                case "DataTableId":
                    e.Column.HeaderText = "数据表编号";
                    break;
                case "Longtitude":
                    e.Column.HeaderText = "经度";
                    break;
                case "Latitude":
                    e.Column.HeaderText = "纬度";
                    break;
                case "Mileage":
                    e.Column.HeaderText = "里程";
                    break;
            }
        }
        public void ShowAllCollectInfo()
        {
            ArrayList AllCollectInfoIdList = new ArrayList();
            DataSet CollectInfoIdDataSet = OleHelper.ExecuteDataset("select id from CollectInfo");
            foreach (DataRow row in CollectInfoIdDataSet.Tables[0].Rows)
            {
                AllCollectInfoIdList.Add(row["id"].ToString());
            }

            this.ShowCollectInfo(AllCollectInfoIdList);
        }
        /// <summary>
        /// 初始化数据，显示所有采集点的最新一条信息，双击显示该采集点的所有采集数据
        /// </summary>
        public void ShowCollectInfo(ArrayList CollectInfoList)
        {

            CollectDataTable = new DataTable();
            CollectDataTable.Columns.Add("ProtectStationName");
            CollectDataTable.Columns.Add("TestPileID");
            CollectDataTable.Columns.Add("CollectId");
            CollectDataTable.Columns.Add("DataTime");
            CollectDataTable.Columns.Add("DataValue");
            CollectDataTable.Columns.Add("Mileage");
            CollectDataTable.Columns.Add("Longtitude");
            CollectDataTable.Columns.Add("Latitude");
            CollectDataTable.Columns.Add("ID");
            foreach (string CollectInfoId in CollectInfoList)
            {
                DataSet topDataSet = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select top 1 * from DataTable left join CollectInfo on DataTable.CollectInfoId=CollectInfo.ID where CollectInfo.ID=" + CollectInfoId + " order by DataTime desc");
                if (topDataSet.Tables[0].Rows.Count == 0)
                    continue;
                DataRow topRow = topDataSet.Tables[0].Rows[0];

                DataRow newRow = CollectDataTable.NewRow();
                foreach (DataColumn column in CollectDataTable.Columns)
                {
                    if (topDataSet.Tables[0].Columns[column.ColumnName.ToString()] != null)
                        newRow[column.ColumnName] = topRow[column.ColumnName].ToString();
                }

                try
                {
                    string titude = newRow["Latitude"].ToString();
                    newRow["Latitude"] = Lib.parseLatitude(titude.Substring(titude.IndexOf('&') + 1));
                    newRow["Longtitude"] = Lib.parseLatitude(titude.Substring(0, titude.IndexOf('&')));
                }
                catch (Exception)
                {
                    newRow["Latitude"] = "格式错误";
                    newRow["Longtitude"] = "格式错误";
                }

                this.CollectDataTable.Rows.Add(newRow);
            }

            UpdateForm update = delegate()
            {
                this.dataGridView1.DataSource = CollectDataTable;
                this.dataGridView1.Columns["ID"].Visible = false;
            };
            this.Invoke(update);
            this.isDetail = false;
        }
        public delegate void UpdateForm();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ChangeView();
        }
        public void ViewDetail(int rowIndex)
        {
            this.dataGridView1.Rows[rowIndex].Selected = true;
            string CollectInfoId = this.dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString();
            string querySql = "Select * from DataTable where CollectInfoId=" + CollectInfoId + " order by DataTime desc";
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, querySql);
            this.oneCollectDataSet = ds;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns["DataValue"].DefaultCellStyle.Format = "F3";
            this.dataGridView1.Columns["DataTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; 
            this.dataGridView1.Columns["DataId"].Visible = false;
            this.dataGridView1.Columns["CollectInfoId"].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ChangeView();
        }
        public int CurrentIndex;
        public void ChangeView()
        {
           
            if (this.isDetail) //如果是详细页面，则不做任何处理
            {               
                //this.isDetail = false;
                ////this.button1.Text = "查看详细";
                //this.dataGridView1.DataSource = this.CollectDataTable;
                //this.dataGridView1.Columns["CollectInfo.CollectId"].Visible = false;
                //this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                //this.dataGridView1.Rows[0].Selected=false;
                //this.dataGridView1.Rows[this.CurrentIndex].Selected = true;
     
            }
            else
            {
                if (this.dataGridView1.Columns["DataId"] != null)
                    return;
                if (this.dataGridView1.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("你还没有选择行，请选择");
                    return;
                }
                else
                {
                    this.CurrentIndex = this.dataGridView1.SelectedRows[0].Index;
                    this.ViewDetail(this.dataGridView1.SelectedRows[0].Index);                  
                    this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.isDetail = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (this.isDetail)
                {
                    foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                    {
                        string DataId = row.Cells["DataId"].Value.ToString();
                        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, "delete from DataTable where DataId=" + DataId);                      
                        this.dataGridView1.Rows.Remove(row);
                    }
                    MessageBox.Show("删除成功");
                }
                else
                {
                    
                   
                    if (MessageBox.Show("你确定要删除采集器编号所包含的所有数据吗?", "删除数据", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                        {
                            string CollectId = row.Cells["DataTable.CollectId"].Value.ToString();
                            OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, "delete from DataTable where CollectId='" + CollectId + "'");
                            this.dataGridView1.Rows.Remove(row);
                        }
                        //MessageBox.Show("删除成功");                    
                    }                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
                return;
            if (this.isDetail)
            {
                //this.oneCollectDataSet.AcceptChanges();
                //foreach (DataRow row in this.oneCollectDataSet.Tables[0].Rows)
                //{
                //    if (row.RowState == DataRowState.Modified)
                //    {
                //        string CollectId = row["Datable.CollectId"].ToString();
                //        string DataTime = row["DataTime"].ToString();
                //        string DataValue = row["DataValue"].ToString();
                //        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, "update DataTable set CollectId='" + CollectId + "',DataTime=#" + DataTime + "#,DataValue=" + DataValue + " where DataId=" + row["DataId"].ToString());
                //    }
                //}
                //this.dataGridView1.DataSource = this.oneCollectDataSet.Tables[0];
                int DataId = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["DataId"].Value.ToString());
                ModifyData m = new ModifyData(DataId);
                if (m.ShowDialog() == DialogResult.OK)
                {
                    DataSet ds= OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from DataTable where DataId=" + DataId.ToString());
                    DataGridViewRow selectRow = this.dataGridView1.SelectedRows[0];
                    DataRow datarow=ds.Tables[0].Rows[0];
                    selectRow.Cells["DataValue"].Value = datarow["DataValue"].ToString();
                    selectRow.Cells["DataTime"].Value = datarow["DataTime"].ToString();
                    selectRow.Cells["DataTableId"].Value = datarow["DataTableId"].ToString();
                }
            }
            else
            {


                string CollectInfoId = this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
           

                SetCollectProperty set = new SetCollectProperty(null,CollectInfoId );
                if (set.ShowDialog() == DialogResult.OK)
                {
                    //DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from CollectInfo where CollectId='" + CollectId.ToString()+"'");
                    //DataGridViewRow selectRow = this.dataGridView1.SelectedRows[0];
                    //DataRow datarow = ds.Tables[0].Rows[0];
                    //selectRow.Cells["ProtectStationName"].Value = datarow["ProtectStationName"].ToString();
                    //selectRow.Cells["TestPileID"].Value = datarow["TestPileID"].ToString();
                    ////selectRow.Cells["DataTableId"].Value = datarow["DataTableId"].ToString();
                    //selectRow.DefaultCellStyle.BackColor = Color.White;
                    //Program.mainForm.ShowCharting(3, null);
                }
            }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("DataTime"))
            //{
            //    Rectangle rect = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //    this.dateTimePicker1.Value = Convert.ToDateTime(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //    this.dateTimePicker1.Location = rect.Location;
            //    this.dateTimePicker1.Size = rect.Size;
            //    this.dateTimePicker1.Visible = true;
                
            //}
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("DataTime"))
            //{
            //    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //    this.dateTimePicker1.Visible = false ;
            //}
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.isDetail)
                return;
            for (int rowIndex = e.RowIndex; rowIndex < e.RowIndex + e.RowCount; rowIndex++)
            {
                DateTime DataTime = Convert.ToDateTime(this.dataGridView1.Rows[rowIndex].Cells["DataTime"].Value.ToString());

                this.dataGridView1.Rows[rowIndex].Cells["DataTime"].Value = DataTime.ToString("yyyy-MM-dd HH:mm:ss");
 

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.isDetail)
                return;
            //if (this.dataGridView1.Columns["CollectId"] != null)
            //{
            //    if (this.dataGridView1.Rows[e.RowIndex].Cells["CollectId"].Value.ToString().Trim() == "")
            //    {
            //        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            //    }
            //}
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "DataValue")
            {
                string dataValue = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (dataValue == "")
                    e.Value = "无数据";
                else
                {
                    Double DataValue = Convert.ToDouble(dataValue);
                    e.Value = DataValue.ToString("f3");
                }
            }
        }

        private void button_property_Click(object sender, EventArgs e)
        {
            string ColumnName="CollectId";
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string CollectId= this.dataGridView1.SelectedRows[0].Cells[ColumnName].Value.ToString();
                SetCollectProperty set = new SetCollectProperty(null,CollectId);

                if (set.ShowDialog() == DialogResult.OK)
                {
                    //DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from CollectInfo where CollectId='" + CollectId.ToString() + "'");
                    //DataGridViewRow selectRow = this.dataGridView1.SelectedRows[0];
                    //DataRow datarow = ds.Tables[0].Rows[0];
                    //selectRow.Cells["ProtectStationName"].Value = datarow["ProtectStationName"].ToString();
                    //selectRow.Cells["TestPileID"].Value = datarow["TestPileID"].ToString();
                    ////selectRow.Cells["DataTableId"].Value = datarow["DataTableId"].ToString();
                    //selectRow.DefaultCellStyle.BackColor = Color.White;                    
                    //this.dataGridView1.Refresh();

                    //Program.mainForm.ShowCharting(3, null);
                }
         
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataArithmetic get = new GetDataArithmetic();
            get.ShowDialog();
        }

        private void dataTree1_Load(object sender, EventArgs e)
        {

        }



    }
}