﻿namespace Voltage
{
    partial class SetProperty
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ProtectStationName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_PipelineName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "保护站名称";
            // 
            // textBox_ProtectStationName
            // 
            this.textBox_ProtectStationName.Location = new System.Drawing.Point(107, 32);
            this.textBox_ProtectStationName.Name = "textBox_ProtectStationName";
            this.textBox_ProtectStationName.Size = new System.Drawing.Size(147, 25);
            this.textBox_ProtectStationName.TabIndex = 1;
            // 
            // textBox_PipelineName
            // 
            this.textBox_PipelineName.Location = new System.Drawing.Point(107, 74);
            this.textBox_PipelineName.Name = "textBox_PipelineName";
            this.textBox_PipelineName.Size = new System.Drawing.Size(147, 25);
            this.textBox_PipelineName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "管线名称";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存";
            this.button1.UseMnemonic = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseMnemonic = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_PipelineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ProtectStationName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetProperty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置属性";
            this.Load += new System.EventHandler(this.SetProperty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_ProtectStationName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_PipelineName;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
    }
}