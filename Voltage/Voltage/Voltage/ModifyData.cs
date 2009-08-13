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
                this.textBox_DataId.Text = DataId.ToString();
                this.textBox_CollectId.Text = row["CollectId"].ToString();
                this.textBox_DataTableId.Text = row["DataTableId"].ToString();
                this.textBox_DataValue.Text = row["DataValue"].ToString();
                this.dateTimePicker1.Value = Convert.ToDateTime(row["DataTime"].ToString());
            }
        }
    }
}
