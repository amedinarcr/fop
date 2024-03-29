﻿namespace Voltage
{
    partial class GetCollectID
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
            this.listBox_Source = new System.Windows.Forms.ListBox();
            this.listBox_Des = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所有采集器编号";
            // 
            // listBox_Source
            // 
            this.listBox_Source.FormattingEnabled = true;
            this.listBox_Source.HorizontalScrollbar = true;
            this.listBox_Source.ItemHeight = 12;
            this.listBox_Source.Location = new System.Drawing.Point(20, 49);
            this.listBox_Source.Name = "listBox_Source";
            this.listBox_Source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Source.Size = new System.Drawing.Size(120, 256);
            this.listBox_Source.TabIndex = 1;
            // 
            // listBox_Des
            // 
            this.listBox_Des.FormattingEnabled = true;
            this.listBox_Des.HorizontalScrollbar = true;
            this.listBox_Des.ItemHeight = 12;
            this.listBox_Des.Location = new System.Drawing.Point(250, 49);
            this.listBox_Des.Name = "listBox_Des";
            this.listBox_Des.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Des.Size = new System.Drawing.Size(120, 256);
            this.listBox_Des.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(225, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择采集器编号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseMnemonic = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = ">>";
            this.button2.UseMnemonic = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "<";
            this.button3.UseMnemonic = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "<<";
            this.button4.UseMnemonic = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "关闭";
            this.button5.UseMnemonic = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(199, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "确定";
            this.button6.UseMnemonic = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // GetCollectID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 358);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Des);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Source);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetCollectID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取采集器编号";
            this.Load += new System.EventHandler(this.GetCollectID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Source;
        private System.Windows.Forms.ListBox listBox_Des;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button6;
    }
}