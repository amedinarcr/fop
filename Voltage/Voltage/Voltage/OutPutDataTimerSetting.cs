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
            for (int i = 1; i <= 31; i++)
            {
                this.kryptonComboBox_OutPutDay.Items.Add(i.ToString());
            }
            this.checkBox1.Checked = Voltage.Properties.Settings.Default.IsOpenOutPutTimer;
            this.textBox1.Text = Voltage.Properties.Settings.Default.OutPutDataDir;
            this.kryptonComboBox_OutPutDay.Text = Voltage.Properties.Settings.Default.OutPutDay.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lib.UpdateApplicationSetting("IsOpenOutPutTimer", this.checkBox1.Checked.ToString());
            Lib.UpdateApplicationSetting("OutPutDataDir", this.textBox1.Text);
            Lib.UpdateApplicationSetting("OutPutDay", this.kryptonComboBox_OutPutDay.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
