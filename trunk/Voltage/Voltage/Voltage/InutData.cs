using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
namespace Voltage
{
    public partial class InputData : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public StringBuilder data;
        public string oldString="";
        public DataTable SerialDataTable;
        public DataTable CollectInfoTable;
        public Thread task;
        public bool isNewData = false;
        public string fileName;
        public InputData()
        {
            
            InitializeComponent();
            this.button2.Enabled = false;
          
            //Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void InputData_Load(object sender, EventArgs e)
        {
           
                //this.label2.Text = "正在读取数据，请稍候...";
                //this.label1.Text = "";
           
                //this.dataGridView1.Visible = false;
                //task = new Thread(new ThreadStart(receiveData));
                //task.Start();
            this.comboBox_DataExist.SelectedIndex = 0;
            
        }
        public void BindData(DataTable dt)
        {
            this.SerialDataTable = dt;
            this.dataGridView1.DataSource = this.SerialDataTable;
        }
        public void receiveData()
        {
            this.oldString = "";
            this.SerialDataTable = null;
            while (this.oldString.Length < this.data.ToString().Length)
            {
                this.oldString = this.data.ToString();
                System.Threading.Thread.Sleep(3000);
            }
            //MessageBox.Show("获取结束");
            //this.label1.Text = "采集完毕，正在分析数据...";
            this.SaveData();
            //this.label2.Visible = false;
            this.dataGridView1.Visible = true;
        }
        public void SaveData()
        {
            try
            {
                string m_strRXData_old = this.data.ToString();
                if (m_strRXData_old == "")
                {
                    MessageBox.Show("没有读取到任何数据，请检查下位机是否连接正确！");                   
                    return;
                }
                string m_strRXData = "";
                for (int i = 0; i < m_strRXData_old.Length / 2; i++)
                {
                    m_strRXData += m_strRXData_old.Substring(2 * i, 2) + " ";
                }

                string DataTableId = m_strRXData.Substring(6, 5).Replace(" ", ""); //数据表编码
                int num = (m_strRXData.Length / 3 - 18) / 8 - this.getSubStringCount(m_strRXData, "A1");
                int num2 = (m_strRXData.Length / 3 - 18) / 8;

                this.SerialDataTable = new DataTable();
                DataTable dt = this.SerialDataTable;
                dt.Columns.Add("CollectId");
                dt.Columns.Add("DataTime");
                dt.Columns.Add("DataValue");
                dt.Columns.Add("DataTableId");
                int baseNum = 30;
                string CollectorId = "";
                int j = 0;
                for (int i = 0; i < num2; i++)
                {
                    if (m_strRXData[baseNum + i * 24] == 'A')
                    {

                        CollectorId = m_strRXData.Substring(baseNum + i * 24 + 12, 5);
                    }
                    else
                    {
                        DataRow row = dt.NewRow();
                        row["CollectId"] = CollectorId.Replace(" ", "");
                        row["DataTime"] = this.parseDateTime(m_strRXData.Substring(baseNum + i * 24, 17));
                        row["DataValue"] = Convert.ToDouble(m_strRXData.Substring(baseNum + i * 24 + 18, 5).Replace(" ", "")) / 1000;
                        row["DataTableId"] = DataTableId;
                        j++;
                        dt.Rows.Add(row);
                    }
                }
                UpdateForm update = delegate()
                {

                    this.dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                    //this.label1.Text = "分析数据完毕";
                    this.button2.Enabled = true;
                };
                this.Invoke(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据失败!\n原因:\n\t" + ex.Message.ToString(),"读取数据失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public delegate void UpdateForm();
        
        public DateTime parseDateTime(string str)
        { 
            int year = Convert.ToInt16("20" + str.Substring(0, 2));
            int month = Convert.ToInt16(str.Substring(3, 2));
            int Day = Convert.ToInt16(str.Substring(6, 2));
            int Hour = Convert.ToInt16(str.Substring(9, 2));
            int Minute = Convert.ToInt16(str.Substring(12, 2));
            int Second = Convert.ToInt16(str.Substring(15, 2));
            DateTime dt = new DateTime(year,month,Day,Hour,Minute,Second);
            return dt;

        }
        public int getSubStringCount(string source, string value)
        {
            int count = 0;
            int index = 0;
            while ((index = source.IndexOf(value, index)) != -1)
            {
                index++;
                count++;
            }
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task.Abort();
            DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ColumnIndex = 0;

            if (this.dataGridView1.Columns["状态"] == null)
                ColumnIndex = this.dataGridView1.Columns.Add("状态", "状态");
            else
            {
                ColumnIndex = this.dataGridView1.Columns["状态"].Index;
            }
            this.dataGridView1.Columns[ColumnIndex].DefaultCellStyle.ForeColor = Color.Green;
            //this.label1.Text = "正在导入数据";
            task=new Thread(new ThreadStart(insertData));
            task.Start();
        }

        public void insertData()
        {
            try
            {
                int insertCount = 0;
                int i = 0;
                foreach (DataRow row in this.SerialDataTable.Rows)
                {
                    string CollectId = row["CollectInfoId"].ToString();
                    DateTime dataTime = Convert.ToDateTime(row["DataTime"].ToString());

                    string querySql = "Select DataId from DataTable where CollectInfoId=" + CollectId + " and DataTime=#" + dataTime.ToString() + "#";

                    if (OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, querySql) == null)
                    {
                        string insertSql = "insert into DataTable(CollectInfoId,DataTime,DataValue,DataTableId) values(" + CollectId + ",#" + dataTime.ToString() + "#," + row["DataValue"].ToString() + ",'" + row["DataTableId"].ToString() + "')";
                        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql);
                        insertCount++;
                        UpdateForm update = delegate()
                        {
                            this.dataGridView1.Rows[i].Cells["状态"].Value = "导入成功";
                            //this.dataGridView1.Rows[i].Selected = true;
                            if (i - 5 > 0)
                                this.dataGridView1.FirstDisplayedScrollingRowIndex = i - 5;
                        };
                        this.Invoke(update);
                    }
                    else
                    {
                        UpdateForm update = delegate()
                        {
                            this.dataGridView1.Rows[i].Cells["状态"].Value = "数据已存在";
                            //this.dataGridView1.Rows[i].Selected = true;
                            if (i - 5 > 0)
                                this.dataGridView1.FirstDisplayedScrollingRowIndex = i - 5;
                        };
                        this.Invoke(update);
                    }

                    i++;
                }
                //插入采集器编号信息
                foreach (DataRow row in this.CollectInfoTable.Rows)
                {
                    string PipelineName = row["PipelineName"].ToString();
                    string ID = row["ID"].ToString();
                    OleDbParameter p_PipelineName = new OleDbParameter("PipelineName", PipelineName);
                    OleDbParameter p_CollectId = new OleDbParameter("CollectId", row["CollectId"].ToString());
                    p_CollectId.OleDbType = OleDbType.Integer;
                    object CollectIdObject = OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, "select CollectId from CollectInfo where PipelineName=@PipelineName and ID=@CollectId", new OleDbParameter[] { p_PipelineName, p_CollectId });
                    if (CollectIdObject == null)
                    {
                        string insertSql = "insert into CollectInfo(CollectId,ProtectStationName,TestPileID,PipelineName,Mileage,Latitude,Remark,LineWidth,LineStyle,LineColor,SymbolType) values(@CollectId,@ProtectStationName,@TestPileID,@PipelineName,@Mileage,@Latitude,@Remark,@LineWidth,@LineStyle,@LineColor,@SymbolType)";
                        //OleDbParameter p_CollectId = new OleDbParameter("@CollectId", CollectId);
                        OleDbParameter p_ProtectStationName = new OleDbParameter("@ProtectStationName", row["ProtectStationName"].ToString());
                        OleDbParameter p_TestPileID = new OleDbParameter("@TestPileID", row["TestPileID"].ToString());
                        //OleDbParameter p_PipelineName = new OleDbParameter("@PipelineName", row["PipelineName"].ToString());
                        OleDbParameter p_Mileage = new OleDbParameter("@Mileage", row["Mileage"].ToString());
                        OleDbParameter p_Latitude = new OleDbParameter("@Latitude", row["Latitude"].ToString());
                        OleDbParameter p_Remark = new OleDbParameter("@Remark", row["remark"].ToString());
                        OleDbParameter p_LineWidth = new OleDbParameter("@LineWidth", row["LineWidth"].ToString());
                        p_LineWidth.OleDbType = OleDbType.Integer;
                        OleDbParameter p_LineStyle = new OleDbParameter("@LineStyle", row["LineStyle"].ToString());
                        p_LineStyle.OleDbType = OleDbType.Integer;
                        OleDbParameter p_LineColor = new OleDbParameter("@LineColor", row["LineColor"].ToString());
                        p_LineColor.OleDbType = OleDbType.Integer;
                        OleDbParameter p_SymbolType = new OleDbParameter("@SymbolType", row["SymbolType"].ToString());
                        p_SymbolType.OleDbType = OleDbType.Integer;
                        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql, new OleDbParameter[] { p_CollectId, p_ProtectStationName, p_TestPileID, p_PipelineName, p_Mileage, p_Latitude, p_Remark, p_LineWidth, p_LineStyle, p_LineColor, p_SymbolType });
                    }
                }
                UpdateForm update2 = delegate()
                {
                    //this.label1.Text = "已保存" + insertCount.ToString() + "条数据";
                };
                this.Invoke(update2);
                if (insertCount > 0)
                    this.isNewData = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("插入数据失败!\n错误原因:\n" + ex.Message);
                this.Close();
            }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch(e.Column.Name)
            {
                case "CollectId":
                    e.Column.HeaderText="采集器编号";
                    break;
                case "DataTime":
                    e.Column.HeaderText = "采集时间";
                    break;
                case "DataValue":
                    e.Column.HeaderText = "电位值";
                    break;
                case "DataTableId":
                    e.Column.HeaderText = "数据表";
                    break;
                case "DataId":
                    e.Column.Visible = false;
                    break;
            }
  
        }

        private void InputData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isNewData)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter =  "通用文件格式|*.xml";//|Excel文件格式|*.xls";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fileName = this.openFileDialog1.FileName;
                this.textBox_fileName.Text = this.fileName;        
            }
        
        }
        public void ReadXmlData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(this.fileName);
            if (ds.Tables.Count>=1&&ds.Tables[0] != null)
            {
                this.SerialDataTable = ds.Tables[0];
                if (ds.Tables.Count>=2&&ds.Tables[1] != null)
                    this.CollectInfoTable = ds.Tables[1];
            }
            else
            {
                MessageBox.Show("此文件已被损坏，系统不能读取!");
                return;
            }
        }
        public void ReadXlsData()
        {
            Excel.ExcelEdit excel = new Excel.ExcelEdit();
            excel.Open(this.fileName);
            this.SerialDataTable = new DataTable();
            if (this.SerialDataTable.Columns.Count == 0)
            {
                this.SerialDataTable.Columns.Add("PipelineName");
                this.SerialDataTable.Columns.Add("CollectId");
                this.SerialDataTable.Columns.Add("TestPileID");
                this.SerialDataTable.Columns.Add("DataValue");
                this.SerialDataTable.Columns.Add("DataTime");
                this.SerialDataTable.Columns.Add("AdminName");
            }
            if (this.SerialDataTable.Rows.Count > 0)
                this.SerialDataTable.Rows.Clear();

            
            excel.ReadTable(this.SerialDataTable, "Sheet1", 13, 1);
        }
       
        public DataTable InsertXMLData(string fileName)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(fileName);
                int insertCount = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string CollectId = row["CollectInfoId"].ToString();
                    DateTime dataTime = Convert.ToDateTime(row["DataTime"].ToString());
                    string querySql = "Select DataId from DataTable where CollectInfoId='" + CollectId + "' and DataTime=#" + dataTime.ToString() + "#";
                    if (OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, querySql) == null)
                    {
                        string insertSql = "insert into DataTable(CollectInfoId,DataTime,DataValue) values('" + CollectId + "',#" + row["DataTime"].ToString() + "#," + row["DataValue"].ToString() + ")";
                        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql);
                        insertCount++;
                    }
                }
                MessageBox.Show("插入" + insertCount.ToString() + "条数据");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入数据失败" + Environment.NewLine + "错误信息:" + ex.Message);
            }
            return null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.fileName != null)
            {
                switch (this.fileName.Substring(this.fileName.Length - 3, 3).ToLower())
                {
                    case "xml":
                        ReadXmlData();
                        break;
                    case "xls":
                        ReadXlsData(); break;
                }
                foreach (DataRow row in this.SerialDataTable.Rows)
                {
                    row["DataValue"] = (Convert.ToDouble(row["DataValue"].ToString())).ToString("F3");
                    row["DataTime"] = (Convert.ToDateTime(row["DataTime"].ToString())).ToString("yyyy-MM-dd HH:mm:ss");
                }
                this.dataGridView1.DataSource = this.SerialDataTable;
                this.dataGridView1.Columns["CollectInfoId"].Visible = false;
                this.button2_Click(null, null);
            }
        }
        

    }
}
