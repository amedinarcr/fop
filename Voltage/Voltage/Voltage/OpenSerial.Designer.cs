namespace Voltage
{
    partial class OpenSerial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OpenSerial = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comboBox_Serial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OpenSerial
            // 
            this.button_OpenSerial.Location = new System.Drawing.Point(200, 27);
            this.button_OpenSerial.Name = "button_OpenSerial";
            this.button_OpenSerial.Size = new System.Drawing.Size(75, 25);
            this.button_OpenSerial.TabIndex = 3;
            this.button_OpenSerial.Text = "打开串口";
            this.button_OpenSerial.UseMnemonic = true;
            this.button_OpenSerial.Click += new System.EventHandler(this.button_OpenSerial_Click);
            // 
            // comboBox_Serial
            // 
            this.comboBox_Serial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Serial.FormattingEnabled = true;
            this.comboBox_Serial.Location = new System.Drawing.Point(71, 29);
            this.comboBox_Serial.Name = "comboBox_Serial";
            this.comboBox_Serial.Size = new System.Drawing.Size(111, 20);
            this.comboBox_Serial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "可用串口";
            // 
            // OpenSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OpenSerial);
            this.Controls.Add(this.comboBox_Serial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打开串口";
            this.Load += new System.EventHandler(this.OpenSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton button_OpenSerial;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBox_Serial;
        private System.Windows.Forms.Label label1;
    }
}