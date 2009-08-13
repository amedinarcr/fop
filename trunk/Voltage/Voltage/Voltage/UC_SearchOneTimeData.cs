using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

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
            string sql = "select CollectId,DataValue from DataTable where DataTime=#" + this.dateTimePicker1.Value.ToString() + "# order by CollectId asc";
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text,sql);
            OneTimeZendChart zend = this.ParentForm as OneTimeZendChart;
            zend.ShowChartingForOneTime(ds);
    
        }

        private void UC_SearchOneTimeData_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = new DateTime(2008, 12, 20, 8, 0, 1);
        }
    }
}
