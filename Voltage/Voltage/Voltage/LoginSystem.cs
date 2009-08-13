using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Voltage.Properties;

namespace Voltage
{
    public partial class LoginSystem : Form
    {
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lib.UpdateApplicationSetting("ProtectStationName", this.textBox_ProtectStationName.Text);
            Lib.UpdateApplicationSetting("PipelineName", this.textBox_PipelineName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void LoginSystem_Load(object sender, EventArgs e)
        {
            this.textBox_ProtectStationName.Text = Settings.Default.ProtectStationName;
            this.textBox_PipelineName.Text = Settings.Default.PipelineName;
            this.button1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
