using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class OutPutDataTimerSetting : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public OutPutDataTimerSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void OutPutDataTimerSetting_Load(object sender, EventArgs e)
        {
            this.checkBox1.Checked = Voltage.Properties.Settings.Default.IsOpenOutPutTimer;
            this.textBox1.Text = Voltage.Properties.Settings.Default.OutPutDataDir;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lib.UpdateApplicationSetting("IsOpenOutPutTimer", this.checkBox1.Checked.ToString());
            Lib.UpdateApplicationSetting("OutPutDataDir", this.textBox1.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
