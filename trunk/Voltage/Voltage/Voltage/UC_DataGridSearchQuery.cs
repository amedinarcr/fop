using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class UC_DataGridSearchQuery : UserControl 
    {
        public DataSet ds;
        public int Type;
        public UC_DataGridSearchQuery()
        {
            //this.Type = Type;
            InitializeComponent();
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.kryptonDropButton1.Text = NullTxt;

        }
        public string NullTxt = "(请选择采集器编号)";
        public UC_DataGridSearchQuery(int Type)
        {
            this.Type = Type;
            InitializeComponent();
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.kryptonDropButton1.Text = NullTxt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList list = new ArrayList();
            ////GetCollectID get = new GetCollectID(list,this.textBox_CollectId.Text.Split(','));
            ////if (get.ShowDialog() == DialogResult.OK)
            ////{
            ////    this.textBox_CollectId.Text = list[0].ToString();
            ////}
            //ArrayList CollectInfoList=new ArrayList();
            //GetCollectInfoId get = new GetCollectInfoId(CollectInfoList);
            //if (get.ShowDialog() == DialogResult.OK)
            //{
            //    string CollectInfoListString = "";
            //    foreach (string CollectInfoId in CollectInfoList)
            //        CollectInfoListString += CollectInfoId + ",";
            //    if (CollectInfoList.Count != 0)
            //        CollectInfoListString = CollectInfoListString.Substring(0, CollectInfoListString.Length - 1);
            //    this.textBox_CollectId.Text = CollectInfoListString;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.kryptonDropButton1.Text.Trim() == this.NullTxt)
            {
                MessageBox.Show("请先选择采集编号");
                return;
            }
            this.ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectInfo.CollectId as CollectId,DataTime,TestPileID,DataValue,PipelineName,Mileage,ProtectStationName,TestPileID from DataTable left join CollectInfo on DataTable.CollectInfoId=CollectInfo.ID where DataTable.CollectInfoId in (" + this.kryptonDropButton1.Text + ") and DataTime>=#" + this.dateTimePicker_StartTime.Value.ToString() + "# and DataTime<=#" + this.dateTimePicker_EndTime.Value.ToString() + "# order by DataTime asc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                ZendChart zend=this.ParentForm as ZendChart;
                zend.setControlVisible();
                zend.ShowCharting(this.ds);
                //Program.mainForm.ShowCharting(this.Type, this.ds);
            }
                
            else
                MessageBox.Show("没有数据");                
        }

        private void UC_DataGridSearchQuery_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_StartTime.Value = new DateTime(2008, 12, 20, 8, 0, 0);
            this.dateTimePicker_EndTime.Value = new DateTime(2008, 12, 20, 8, 0, 15);
            DateTime latestDataTime = Convert.ToDateTime(OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, "select top 1 DataTime from DataTable order by DataTime desc"));
      
            this.dateTimePicker_EndTime.Value = latestDataTime;
            this.dateTimePicker_StartTime.Value=latestDataTime.AddDays(-30);
        }

        private void kryptonDropButton1_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
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
