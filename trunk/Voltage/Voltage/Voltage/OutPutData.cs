using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Excel;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class OutPutData : Form
    {
        private int DataType;
        public BackgroundWorker bWorker;
        public OutPutData(int DataType)
        {
            this.DataType = DataType; //0为XML标准格式，1为Excel文件格式
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.bWorker!=null)
                this.bWorker.CancelAsync(); ;         
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            
            GetCollectID get = new GetCollectID(list,this.textBox_CollectId.Text.Split(','));
            if (get.ShowDialog() == DialogResult.OK)
            {
                this.textBox_CollectId.Text = list[0].ToString();
            }
        }

        private void OutPutData_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd         hh:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd         hh:mm:ss";

            DataSet CollectDataSet = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select distinct CollectId from DataTable order by CollectId asc");
            StringBuilder Collectbuilder = new StringBuilder();
            foreach (DataRow row in CollectDataSet.Tables[0].Rows)
            {
                Collectbuilder.Append("'" + row[0].ToString() + "',");
            }
            if (Collectbuilder.ToString().Length > 1)
            {
                Collectbuilder.Remove(Collectbuilder.Length - 1, 1);
            }
            this.textBox_CollectId.Text = Collectbuilder.ToString();

            switch (DataType)
            {
                case 0:
                    this.saveFileDialog1.Filter = "XML文件|*.xml";
                    break;
                case 1:
                    this.saveFileDialog1.Filter = "Excel文件|*.xls";
                    break;
            }


            //初始化显示时间，接着上一次导出时间的往后一个月
            DateTime dt = Voltage.Properties.Settings.Default.LastOutputTime;
            dt = dt.AddSeconds(1);
            if (dt > this.dateTimePicker_StartTime.MinDate && dt < this.dateTimePicker_StartTime.MaxDate)
            {
                this.dateTimePicker_StartTime.Value = dt;
                this.dateTimePicker_EndTime.Value = dt.AddMonths(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox_CollectId.Text.Trim() == "")
            {
                MessageBox.Show("请先选择采集编号");
                return;
            }
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label_info.Text = "正在导出数据，请稍候...";
                bWorker = new BackgroundWorker();
                bWorker.WorkerSupportsCancellation = true;
                bWorker.DoWork += new DoWorkEventHandler(bWorker_DoWork);
                bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bWorker_RunWorkerCompleted);
                bWorker.RunWorkerAsync(this.saveFileDialog1.FileName); 
                
            }
        }

        void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                switch (this.DataType)
                {
                    case 0:
                        DataSet ds=new DataSet();
                        DataTable dt1 = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from DataTable where  CollectId in (" + this.textBox_CollectId.Text + ") and DataTime>=#" + this.dateTimePicker_StartTime.Value + "# and DataTime<=#" + this.dateTimePicker_EndTime.Value + "#").Tables[0].Copy();
                        dt1.TableName = "DataTable";
                        DataTable dt2 = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from CollectInfo").Tables[0].Copy();
                        dt2.TableName = "CollectInfo";
                        ds.Tables.Add(dt1);
                        ds.Tables.Add(dt2);
                        ds.WriteXml(e.Argument.ToString());
                        break;
                    case 1:
                        ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectInfo.PipelineName,'',CollectInfo.TestPileID,DataValue,DataTime,CollectInfo.AdminName from DataTable left join CollectInfo on DataTable.CollectId=Collectinfo.CollectId  where DataTable.CollectId in (" + this.textBox_CollectId.Text + ") and DataTime>=#" + this.dateTimePicker_StartTime.Value + "# and DataTime<=#" + this.dateTimePicker_EndTime.Value + "#");

                        ExcelEdit excel = new ExcelEdit();
                        excel.Open(Application.StartupPath + "\\Model.xls");
                        excel.AddTable(ds.Tables[0], "Sheet1", 13, 1);
                        if (excel.SaveAs(e.Argument.ToString()) == false)
                        {
                            MessageBox.Show("保存失败");
                        }
                        excel.Close();
                        break;
                }
                Lib.UpdateApplicationSetting("LastOutputTime", this.dateTimePicker_EndTime.Value.ToString());
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败!\n失败原因:\n\t" + ex.Message);
            }

   
        }

        void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                MessageBox.Show("导出成功");
                this.label_info.Text = "导出成功";
            }
            if (e.Cancelled)
            {
                this.label_info.Text = "导出取消";
            }
        }

        private void OutPutData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bWorker != null)
                this.bWorker.CancelAsync();
        }
    }
}
