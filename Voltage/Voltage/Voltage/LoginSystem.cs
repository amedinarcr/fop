using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Voltage.Properties;
using ComponentFactory.Krypton.Toolkit;

namespace Voltage
{
    public partial class LoginSystem : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        public LoginSystem()
        {
           
            InitializeComponent();
            this.LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lib.UpdateApplicationSetting("ProtectStationName", this.textBox_ProtectStationName.Text);
            Lib.UpdateApplicationSetting("PipelineName", this.textBox_PipelineName.Text);
            this.DialogResult = DialogResult.OK;
        }
        public void LoadTheme()
        {
            this.components = new System.ComponentModel.Container();
            string ThemeName = Voltage.Properties.Settings.Default.ThemeName.Trim();
            if (ThemeName.Trim() == "")
            {
                ThemeName = "Office2007Blue";              
            }
            this.kryptonManager = new KryptonManager(this.components);
            try
            {
                this.kryptonManager.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteModeManager), ThemeName, false);
            }
            catch (Exception ex)
            {
                this.kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
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
