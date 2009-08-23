using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel;

namespace Voltage
{
    public partial class test : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BackgroundWorker bWorker = new BackgroundWorker();
                bWorker.DoWork += new DoWorkEventHandler(bWorker_DoWork);
                bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bWorker_RunWorkerCompleted);
                bWorker.RunWorkerAsync(this.saveFileDialog1.FileName);
            }
        }

        void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select top 30 * from DataTable");
            ExcelEdit excel = new ExcelEdit();
            excel.Open(Application.StartupPath + "\\Model.xls");
            excel.AddTable2(ds.Tables[0],"Sheet1", 13, 1);
            if (excel.SaveAs(e.Argument.ToString()) == false)
            {
                MessageBox.Show("保存失败");
            }
            excel.Close();
        }

        void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("导出成功");
        }
    }
}
