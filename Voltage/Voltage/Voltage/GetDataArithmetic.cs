using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class GetDataArithmetic : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public DataSet ds;
        public GetDataArithmetic()
        {
            InitializeComponent();
            this.kryptonDropButton1.Text = NullTxt;
        }
        public string NullTxt = "(请选择采集器编号)";
        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            if (this.kryptonDropButton1.Text.Trim() == NullTxt)
            {
                MessageBox.Show("请先选择采集编号");
                return;
            }
            //   string[] CollectIdList = this.textBox_CollectId.Text.Substring("'", "").Split(',');
            ArrayList CollectIdList = new ArrayList(this.kryptonDropButton1.Text.Replace("'", "").Split(','));
            ArrayList[] list = new ArrayList[CollectIdList.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new ArrayList();
            }
            this.ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectInfo.CollectId as CollectId,PipeLineName,CollectInfoId,DataTime,DataValue from DataTable left join CollectInfo on DataTable.CollectInfoId=CollectInfo.ID where CollectInfoId in (" + this.kryptonDropButton1.Text + ") and DataTime>=#" + this.dateTimePicker_StartTime.Value.ToString() + "# and DataTime<=#" + this.dateTimePicker_EndTime.Value.ToString() + "# order by DataTime asc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in this.ds.Tables[0].Rows)
                {

                    int index = CollectIdList.IndexOf(row["CollectInfoId"].ToString());
                    list[index].Add(row["DataValue"].ToString());
                }
                for (int i = 0; i < list.Length; i++)
                {
                    this.getResult(ds.Tables[0].Rows[i]["PipeLineName"].ToString(), ds.Tables[0].Rows[i]["CollectId"].ToString(), list[i]);
                }
            }

            else
                MessageBox.Show("没有数据");
        }
        public void getResult(string PipeLineName,string CollectId, ArrayList DataValueList)
        {
            double allValue = 0;
            foreach (string dataValue in DataValueList)
                allValue += Convert.ToDouble(dataValue);
            double average = allValue / DataValueList.Count;
            double variance = 0;
            foreach (string dataValue in DataValueList)
            {
                variance += Math.Pow((Convert.ToDouble(dataValue) - average), 2);
            }
            variance = variance / DataValueList.Count;

            this.dataGridView1.Rows.Add(new object[] { PipeLineName,CollectId, average.ToString("f3"), variance.ToString("f3") });
        }
        private void GetDataArithmetic_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dataGridView1.RowHeadersWidth = 16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList CollectInfoList = new ArrayList();
            GetCollectInfoId get = new GetCollectInfoId(CollectInfoList);
            //GetCollectID get = new GetCollectID(list, this.kryptonDropButton1.Text.Split(','));
            if (get.ShowDialog() == DialogResult.OK)
            {
               
                string CollectInfoListString = "";
                foreach (string CollectInfoId in CollectInfoList)
                    CollectInfoListString += CollectInfoId + ",";
                if (CollectInfoList.Count != 0)
                    CollectInfoListString = CollectInfoListString.Substring(0, CollectInfoListString.Length - 1);
                this.kryptonDropButton1.Text = CollectInfoListString;
            }
        }

        private void button1_Click(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            ArrayList CollectInfoList = new ArrayList();
            GetCollectInfoId get = new GetCollectInfoId(CollectInfoList);
            //GetCollectID get = new GetCollectID(list, this.kryptonDropButton1.Text.Split(','));
            if (get.ShowDialog() == DialogResult.OK)
            {

                string CollectInfoListString = "";
                foreach (string CollectInfoId in CollectInfoList)
                    CollectInfoListString += CollectInfoId + ",";
                if (CollectInfoList.Count != 0)
                    CollectInfoListString = CollectInfoListString.Substring(0, CollectInfoListString.Length - 1);
                if (CollectInfoListString.Trim() != "")
                    this.kryptonDropButton1.Text = CollectInfoListString;
            }
        }
    }
}
