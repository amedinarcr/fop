using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class ModifyData : Form
    {
        private int DataId;
        public ModifyData(int DataId)
        {
            this.DataId = DataId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyData_Load(object sender, EventArgs e)
        {

            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from DataTable where DataId=" + this.DataId.ToString());
            DataRow row=ds.Tables[0].Rows[0];
            if (row != null)
            {
                this.label_DataId.Text = DataId.ToString();
                this.textBox_DataTableId.Text = row["DataTableId"].ToString();
                this.textBox_DataValue.Text = row["DataValue"].ToString();
                this.dateTimePicker1.Value = Convert.ToDateTime(row["DataTime"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update DataTable set DataValue=" + this.textBox_DataValue.Text + ",DataTime='" + this.dateTimePicker1.Value + "',DataTableId='"+this.textBox_DataTableId.Text+"' where DataId="+this.label_DataId.Text;

            OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, sql);
            DialogResult = DialogResult.OK;
        }
    }
}
