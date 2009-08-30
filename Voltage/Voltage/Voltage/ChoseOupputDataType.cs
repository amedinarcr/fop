using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class ChoseOupputDataType : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private int DataType;
        public BackgroundWorker bWorker;
        private static int nNextBackCount;
        public ChoseOupputDataType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            this.Close();
        }
        
        private void ChoseOupputDataType_Load(object sender, EventArgs e)
        {
            nNextBackCount = 0;
            this.comboBox1.Items.Add("标准通信格式");
            this.comboBox1.Items.Add("Excel文件格式");
            this.comboBox1.SelectedIndex = 0;
            DataType = this.comboBox1.SelectedIndex;
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd         hh:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd         hh:mm:ss";

            DataSet CollectDataSet = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select distinct CollectInfoId from DataTable order by CollectInfoId asc");
            StringBuilder Collectbuilder = new StringBuilder();
            foreach (DataRow row in CollectDataSet.Tables[0].Rows)
            {
                Collectbuilder.Append(row[0].ToString() + ",");
            }
            if (Collectbuilder.ToString().Length > 1)
            {
                Collectbuilder.Remove(Collectbuilder.Length - 1, 1);
            }
            //this.textBox_CollectId.Text = Collectbuilder.ToString();


            //初始化显示时间，接着上一次导出时间的往后一个月
            DateTime dt = Voltage.Properties.Settings.Default.LastOutputTime;
            dt = dt.AddSeconds(1);
            if (dt > this.dateTimePicker_StartTime.MinDate && dt < this.dateTimePicker_StartTime.MaxDate)
            {
                this.dateTimePicker_StartTime.Value = dt;
                this.dateTimePicker_EndTime.Value = dt.AddMonths(1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataType = this.comboBox1.SelectedIndex;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OutPutData output = new OutPutData(this.comboBox1.SelectedIndex);
            output.ShowDialog();
            this.Close();
        }
        private void wizardControl1_NextButtonClick(object sender, EventArgs e)
        {
            nNextBackCount+=1;

            if (nNextBackCount==2)
            {
                this.wizardControl1.BackButtonVisible = false;
                this.wizardControl1.NextButtonVisible = false;
                switch (DataType)
                {
                    case 0:
                        this.saveFileDialog1.Filter = "XML文件|*.xml";
                        break;
                    case 1:
                        this.saveFileDialog1.Filter = "Excel文件|*.xls";
                        break;
                }
                bWorker = new BackgroundWorker();
                bWorker.WorkerSupportsCancellation = true;
                bWorker.DoWork += new DoWorkEventHandler(bWorker_DoWork);
                bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bWorker_RunWorkerCompleted);
                // bWorker.RunWorkerAsync(this.saveFileDialog1.FileName);
                string fileName = Lib.GetNewFileName();
                if (this.DataType == 0)
                {
                    fileName += ".xml";
                }
                if (this.DataType == 1)
                {
                    fileName += ".xls";
                }
                bWorker.RunWorkerAsync(fileName);


            }
        }
        private void wizardControl1_BackButtonClick(object sender, EventArgs e)
        {
            nNextBackCount -= 1;
        }
        private void wizardControl1_CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void wizardControl1_FinishButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                this.label4.Text = "导出成功";
                this.wizardControl1.BackButtonVisible = true;
                this.wizardControl1.NextButtonVisible = true;
                this.wizardControl1.CancelButtonVisible = false;
            }
            if (e.Cancelled)
            {
                this.label4.Text = "导出取消";
            }
        }
        void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = e.Argument.ToString();
            DateTime startTime = this.dateTimePicker_StartTime.Value;
            DateTime endTime = this.dateTimePicker_EndTime.Value;
            int DataType = this.DataType;
            VoltageData.OutPut(fileName, DataType, startTime, endTime);
            //Lib.OutPutData(DataType, startTime, endTime); //导出数据,DataType 为导出类型
        }
    }
}
