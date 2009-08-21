using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class UC_SearchOneTimeData : UserControl
    {
        public UC_SearchOneTimeData()
        {
            InitializeComponent();
           
            this.dateTimePicker1.CustomFormat="yyyy-MM-dd HH:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_CollectId.Text.Trim() == "")
            {
                MessageBox.Show("请先选择采集编号");
                return;
            }
            string sql = "select CollectInfo.CollectId as CollectId,DataValue,Mileage from DataTable left join CollectInfo on DataTable.CollectInfoId=CollectInfo.ID where DataTable.CollectInfoId in (" + this.textBox_CollectId.Text + ") and DataTime=#" + this.dateTimePicker1.Value.ToString() + "#";
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text,sql);
            OneTimeZendChart zend = this.ParentForm as OneTimeZendChart;
            zend.ShowChartingForOneTime(ds);
    
        }

        private void UC_SearchOneTimeData_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = new DateTime(2008, 12, 20, 8, 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList CollectInfoList = new ArrayList();
            GetCollectInfoId get = new GetCollectInfoId(CollectInfoList);
            if (get.ShowDialog() == DialogResult.OK)
            {
                string CollectInfoListString = "";
                foreach (string CollectInfoId in CollectInfoList)
                    CollectInfoListString += CollectInfoId + ",";
                if (CollectInfoList.Count != 0)
                    CollectInfoListString = CollectInfoListString.Substring(0, CollectInfoListString.Length - 1);
                this.textBox_CollectId.Text = CollectInfoListString;
            }
        }
    }
}
