namespace Voltage
{
    partial class UC_SerialCommControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Serial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.button_OpenSerial = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_outputData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_inputData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // comboBox_Serial
            // 
            this.comboBox_Serial.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.comboBox_Serial.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.comboBox_Serial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Serial.DropDownWidth = 74;
            this.comboBox_Serial.FormattingEnabled = true;
            this.comboBox_Serial.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.comboBox_Serial.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.comboBox_Serial.Location = new System.Drawing.Point(1, 5);
            this.comboBox_Serial.Name = "comboBox_Serial";
            this.comboBox_Serial.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.comboBox_Serial.Size = new System.Drawing.Size(74, 23);
            this.comboBox_Serial.TabIndex = 0;
            // 
            // button_OpenSerial
            // 
            this.button_OpenSerial.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button_OpenSerial.Location = new System.Drawing.Point(81, 3);
            this.button_OpenSerial.Name = "button_OpenSerial";
            this.button_OpenSerial.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button_OpenSerial.Size = new System.Drawing.Size(75, 25);
            this.button_OpenSerial.TabIndex = 1;
            this.button_OpenSerial.Text = "打开串口";
            this.button_OpenSerial.Values.ExtraText = "";
            this.button_OpenSerial.Values.Image = null;
            this.button_OpenSerial.Values.ImageStates.ImageCheckedNormal = null;
            this.button_OpenSerial.Values.ImageStates.ImageCheckedPressed = null;
            this.button_OpenSerial.Values.ImageStates.ImageCheckedTracking = null;
            this.button_OpenSerial.Values.Text = "打开串口";
            this.button_OpenSerial.Click += new System.EventHandler(this.button_OpenSerial_Click);
            // 
            // button1
            // 
            this.button1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "设置下位机时间";
            this.button1.Values.ExtraText = "";
            this.button1.Values.Image = null;
            this.button1.Values.ImageStates.ImageCheckedNormal = null;
            this.button1.Values.ImageStates.ImageCheckedPressed = null;
            this.button1.Values.ImageStates.ImageCheckedTracking = null;
            this.button1.Values.Text = "设置下位机时间";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(303, 3);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "清空数据";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "清空数据";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button3.Location = new System.Drawing.Point(384, 3);
            this.button3.Name = "button3";
            this.button3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "读取数据";
            this.button3.Values.ExtraText = "";
            this.button3.Values.Image = null;
            this.button3.Values.ImageStates.ImageCheckedNormal = null;
            this.button3.Values.ImageStates.ImageCheckedPressed = null;
            this.button3.Values.ImageStates.ImageCheckedTracking = null;
            this.button3.Values.Text = "读取数据";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_outputData
            // 
            this.button_outputData.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button_outputData.Location = new System.Drawing.Point(465, 3);
            this.button_outputData.Name = "button_outputData";
            this.button_outputData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button_outputData.Size = new System.Drawing.Size(75, 25);
            this.button_outputData.TabIndex = 7;
            this.button_outputData.Text = "导出数据";
            this.button_outputData.Values.ExtraText = "";
            this.button_outputData.Values.Image = null;
            this.button_outputData.Values.ImageStates.ImageCheckedNormal = null;
            this.button_outputData.Values.ImageStates.ImageCheckedPressed = null;
            this.button_outputData.Values.ImageStates.ImageCheckedTracking = null;
            this.button_outputData.Values.Text = "导出数据";
            this.button_outputData.Click += new System.EventHandler(this.button_outputData_Click);
            // 
            // button_inputData
            // 
            this.button_inputData.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button_inputData.Location = new System.Drawing.Point(546, 3);
            this.button_inputData.Name = "button_inputData";
            this.button_inputData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button_inputData.Size = new System.Drawing.Size(75, 25);
            this.button_inputData.TabIndex = 8;
            this.button_inputData.Text = "导入数据";
            this.button_inputData.Values.ExtraText = "";
            this.button_inputData.Values.Image = null;
            this.button_inputData.Values.ImageStates.ImageCheckedNormal = null;
            this.button_inputData.Values.ImageStates.ImageCheckedPressed = null;
            this.button_inputData.Values.ImageStates.ImageCheckedTracking = null;
            this.button_inputData.Values.Text = "导入数据";
            this.button_inputData.Click += new System.EventHandler(this.button_inputData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML文件|*.xml";
            // 
            // UC_SerialCommControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_inputData);
            this.Controls.Add(this.button_outputData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_OpenSerial);
            this.Controls.Add(this.comboBox_Serial);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_SerialCommControl";
            this.Size = new System.Drawing.Size(799, 31);
            this.Load += new System.EventHandler(this.UserControl_SerialCommControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBox_Serial;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_OpenSerial;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_outputData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_inputData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
