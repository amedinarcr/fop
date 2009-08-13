using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Voltage
{
    public partial class ViewCollectInfo : Form
    {
        public string CollectId;
        public bool isInfoExist;
        public ViewCollectInfo(string CollectId)
        {
            this.CollectId = CollectId;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCollectInfo_Load(object sender, EventArgs e)
        {
            this.label_CollectId.Text = this.CollectId;
            DataSet ds= OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "Select * from CollectInfo where CollectId='" + this.CollectId + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.isInfoExist = true;
                DataRow row = ds.Tables[0].Rows[0];
                this.textBox_AdminName.Text = row["AdminName"].ToString();
                this.textBox_AdminPhone.Text = row["AdminPhone"].ToString();
                this.textBox_AdminAddress.Text = row["AdminAddress"].ToString();
                this.textBox_CollectAddress.Text = row["CollectAddress"].ToString();
                this.textBox_remark.Text = row["Remark"].ToString();
            }
            else
                this.isInfoExist = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.isInfoExist)
            {
                string updateSql = "Update CollectInfo set AdminName=@AdminName,AdminPhone=@AdminPhone,AdminAddress=@AdminAddress,CollectAddress=@CollectAddress,Remark=@Remark where CollectId='"+this.label_CollectId.Text+"'";
                OleDbParameter p_AdminName = new OleDbParameter("@AdminName", this.textBox_AdminName.Text);
                OleDbParameter p_AdminPhone = new OleDbParameter("@AdminPhone", this.textBox_AdminPhone.Text);
                OleDbParameter p_AdminAddress = new OleDbParameter("@AdminAddress", this.textBox_AdminAddress.Text);
                OleDbParameter p_CollectAddress = new OleDbParameter("@CollectAddress", this.textBox_CollectAddress.Text);
                OleDbParameter p_Remark = new OleDbParameter("@Remark", this.textBox_remark.Text);
                OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, updateSql, new OleDbParameter[] { p_AdminName, p_AdminPhone, p_AdminAddress, p_CollectAddress, p_Remark });

            }
            else
            {
                string insertSql = "insert into COllectInfo(CollectId,AdminName,AdminPhone,AdminAddress,CollectAddress,Remark) values(@CollectId,@AdminName,@AdminPhone,@AdminAddress,@CollectAddress,@Remark)";
                OleDbParameter p_CollectId = new OleDbParameter("@CollectId", this.label_CollectId.Text);
                OleDbParameter p_AdminName = new OleDbParameter("@AdminName", this.textBox_AdminName.Text);
                OleDbParameter p_AdminPhone = new OleDbParameter("@AdminPhone", this.textBox_AdminPhone.Text);
                OleDbParameter p_AdminAddress = new OleDbParameter("@AdminAddress", this.textBox_AdminAddress.Text);
                OleDbParameter p_CollectAddress = new OleDbParameter("@CollectAddress", this.textBox_CollectAddress.Text);
                OleDbParameter p_Remark = new OleDbParameter("@Remark", this.textBox_remark.Text);
                OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql, new OleDbParameter[] { p_CollectId,p_AdminName, p_AdminPhone, p_AdminAddress, p_CollectAddress, p_Remark });
            }
            //MessageBox.Show("保存采集点信息成功!");
            this.Close();
        }
    }
}
