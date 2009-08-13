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
    public partial class GetDataArithmetic : Form
    {
        public DataSet ds;
        public GetDataArithmetic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            if (this.textBox_CollectId.Text.Trim() == "")
            {
                MessageBox.Show("请先选择采集编号");
                return;
            }
            //   string[] CollectIdList = this.textBox_CollectId.Text.Substring("'", "").Split(',');
            ArrayList CollectIdList = new ArrayList(this.textBox_CollectId.Text.Replace("'", "").Split(','));
            ArrayList[] list = new ArrayList[CollectIdList.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new ArrayList();
            }
            this.ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectId,DataTime,DataValue from DataTable where CollectId in (" + this.textBox_CollectId.Text + ") and DataTime>=#" + this.dateTimePicker_StartTime.Value.ToString() + "# and DataTime<=#" + this.dateTimePicker_EndTime.Value.ToString() + "# order by DataTime asc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in this.ds.Tables[0].Rows)
                {

                    int index = CollectIdList.IndexOf(row["CollectId"].ToString());
                    list[index].Add(row["DataValue"].ToString());
                }
                for (int i = 0; i < list.Length; i++)
                {
                    this.getResult(CollectIdList[i].ToString(), list[i]);
                }
            }

            else
                MessageBox.Show("没有数据");
        }
        public void getResult(string CollectId, ArrayList DataValueList)
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
            this.dataGridView1.Rows.Add(new object[] { CollectId, average, variance });
        }
        private void GetDataArithmetic_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dataGridView1.RowHeadersWidth = 16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            GetCollectID get = new GetCollectID(list, this.textBox_CollectId.Text.Split(','));
            if (get.ShowDialog() == DialogResult.OK)
            {
                this.textBox_CollectId.Text = list[0].ToString();
            }
        }
    }
}
