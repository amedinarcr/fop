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
    public partial class SetProperty : Form
    {
        public SetProperty()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lib.UpdateApplicationSetting("ProtectStationName", this.textBox_ProtectStationName.Text);
            Lib.UpdateApplicationSetting("PipelineName", this.textBox_PipelineName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void SetProperty_Load(object sender, EventArgs e)
        {
            this.textBox_ProtectStationName.Text = Settings.Default.ProtectStationName;
            this.textBox_PipelineName.Text = Settings.Default.PipelineName;
        }
    }
}
