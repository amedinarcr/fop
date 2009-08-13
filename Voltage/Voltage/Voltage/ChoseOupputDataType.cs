using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class ChoseOupputDataType : Form
    {
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
            this.comboBox1.Items.Add("标准通信格式");
            this.comboBox1.Items.Add("Excel文件格式");
            this.comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutPutData output = new OutPutData(this.comboBox1.SelectedIndex);
            output.ShowDialog();
            this.Close();
        }
    }
}
