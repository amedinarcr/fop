using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Voltage
{
    public partial class getCollectorData : Form
    {
        public StringBuilder data;
        public string oldString="";
        public DataTable SerialDataTable;
        public Thread task;
        public bool isNewData = false;
        public getCollectorData(StringBuilder data)
        {
            this.data = data;
            InitializeComponent();
            this.button2.Enabled = false;
          
            //Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void getCollectorData_Load(object sender, EventArgs e)
        {
            if (data != null)
            {
                this.label2.Text = "正在读取数据，请稍候...";
                this.label1.Text = "";
                this.dataGridView1.Visible = false;
                task = new Thread(new ThreadStart(receiveData));
                task.Start();
            }
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
            this.label2.Visible = false;
            this.dataGridView1.Visible = true;
        }
        public void SaveData()
        {
            try
            {
                string m_strRXData_old = this.data.ToString();
                if (m_strRXData_old == ""||m_strRXData_old=="FA00")
                {
                    MessageBox.Show("没有读取到任何数据，请检查下位机是否连接正确！");
                    this.data.Remove(0,this.data.ToString().Length);// = "";
                    this.Close();
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
                        string datatime = m_strRXData.Substring(baseNum + i * 24, 17);
                        row["DataTime"] = this.parseDateTime(datatime);
                        row["DataValue"] = (Convert.ToDouble(m_strRXData.Substring(baseNum + i * 24 + 18, 5).Replace(" ", "")) / 1000).ToString("F3");
                        row["DataTableId"] = DataTableId;
                        j++;
                        dt.Rows.Add(row);
                    }
                }
                UpdateForm update = delegate()
                {

                    this.dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                    this.label1.Text = "分析数据完毕";
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
            int ColumnIndex=0;

            if (this.dataGridView1.Columns["状态"] == null)
                ColumnIndex = this.dataGridView1.Columns.Add("状态", "状态");
            else
            {
                ColumnIndex = this.dataGridView1.Columns["状态"].Index;
            }
            this.dataGridView1.Columns[ColumnIndex].DefaultCellStyle.ForeColor = Color.Green;
            this.label1.Text = "正在导入数据...";
            task=new Thread(new ThreadStart(insertData));
            task.Start();
        }

        public void insertData()
        {
            int insertCount = 0;
            int i=0;
            foreach (DataRow row in this.SerialDataTable.Rows)
            {
                string CollectId = row["CollectId"].ToString();
                DateTime dataTime = Convert.ToDateTime(row["DataTime"].ToString());
            
                string querySql = "Select DataId from DataTable where CollectId='" + CollectId + "' and DataTime=#" + dataTime.ToString() + "#";
              
                if (OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, querySql) == null)
                {
                    string insertSql = "insert into DataTable(CollectId,DataTime,DataValue,DataTableId) values('" + CollectId + "',#" + row["DataTime"].ToString() + "#," + row["DataValue"].ToString() + ",'"+row["DataTableId"].ToString()+"')";
                    OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql);
                    insertCount++;
                    UpdateForm update = delegate()
                    {
                        this.dataGridView1.Rows[i].Cells["状态"].Value = "导入成功";
                        //this.dataGridView1.Rows[i].Selected = true;
                        if (i - 5 > 0)
                            this.dataGridView1.FirstDisplayedScrollingRowIndex = i-5;
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
            UpdateForm update2 = delegate()
            {
                this.label1.Text = "已保存" + insertCount.ToString() + "条数据";
            };
            this.Invoke(update2);
            if (insertCount > 0)
                this.isNewData = true;
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
            }
  
        }

        private void getCollectorData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isNewData)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
        

    }
}
