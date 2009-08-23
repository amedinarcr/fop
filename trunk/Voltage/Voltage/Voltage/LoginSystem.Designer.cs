namespace Voltage
{
    partial class LoginSystem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBox_PipelineName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBox_ProtectStationName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voltage.Properties.Resources._2009040216552188;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(320, 186);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "取消";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button1.Location = new System.Drawing.Point(320, 159);
            this.button1.Name = "button1";
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "登陆";
            this.button1.Values.ExtraText = "";
            this.button1.Values.Image = null;
            this.button1.Values.ImageStates.ImageCheckedNormal = null;
            this.button1.Values.ImageStates.ImageCheckedPressed = null;
            this.button1.Values.ImageStates.ImageCheckedTracking = null;
            this.button1.Values.Text = "登陆";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_PipelineName
            // 
            this.textBox_PipelineName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.textBox_PipelineName.Location = new System.Drawing.Point(94, 187);
            this.textBox_PipelineName.Name = "textBox_PipelineName";
            this.textBox_PipelineName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.textBox_PipelineName.Size = new System.Drawing.Size(214, 23);
            this.textBox_PipelineName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label2.Location = new System.Drawing.Point(34, 189);
            this.label2.Name = "label2";
            this.label2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "管线名称";
            this.label2.Values.ExtraText = "";
            this.label2.Values.Image = null;
            this.label2.Values.Text = "管线名称";
            // 
            // textBox_ProtectStationName
            // 
            this.textBox_ProtectStationName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.textBox_ProtectStationName.Location = new System.Drawing.Point(94, 160);
            this.textBox_ProtectStationName.Name = "textBox_ProtectStationName";
            this.textBox_ProtectStationName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.textBox_ProtectStationName.Size = new System.Drawing.Size(214, 23);
            this.textBox_ProtectStationName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label1.Location = new System.Drawing.Point(21, 162);
            this.label1.Name = "label1";
            this.label1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "保护站名称";
            this.label1.Values.ExtraText = "";
            this.label1.Values.Image = null;
            this.label1.Values.Text = "保护站名称";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.button2);
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Controls.Add(this.textBox_PipelineName);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.textBox_ProtectStationName);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonPanel1.Size = new System.Drawing.Size(407, 220);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 220);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阴极电位保护系统";
            this.Load += new System.EventHandler(this.LoginSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_PipelineName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_ProtectStationName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}