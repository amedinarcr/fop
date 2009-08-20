namespace TabStripApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabStrip1 = new RibbonStyle.TabStrip();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tab1 = new RibbonStyle.Tab();
            this.tabStripPage2 = new RibbonStyle.TabStripPage();
            this.tab2 = new RibbonStyle.Tab();
            this.tabPanel1 = new RibbonStyle.TabPanel();
            this.ribbonButton1 = new RibbonStyle.RibbonButton();
            this.panel1.SuspendLayout();
            this.tabStrip1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage2.SuspendLayout();
            this.tabPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabPageSwitcher1);
            this.panel1.Controls.Add(this.tabStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 100);
            this.panel1.TabIndex = 0;
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSize = false;
            this.tabStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1,
            this.tab2});
            this.tabStrip1.Location = new System.Drawing.Point(0, 0);
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tabStrip1.SelectedTab = this.tab2;
            this.tabStrip1.ShowItemToolTips = false;
            this.tabStrip1.Size = new System.Drawing.Size(955, 26);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.TabOverlap = 0;
            this.tabStrip1.Text = "tabStrip1";
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage2);
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage2;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(955, 74);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tabStrip1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabStripPage1.BaseColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(947, 72);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.AutoSize = false;
            this.tab1.Checked = true;
            this.tab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(54, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "tab1";
            // 
            // tabStripPage2
            // 
            this.tabStripPage2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabStripPage2.BaseColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabStripPage2.Caption = "";
            this.tabStripPage2.Controls.Add(this.tabPanel1);
            this.tabStripPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage2.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage2.Name = "tabStripPage2";
            this.tabStripPage2.Opacity = 255;
            this.tabStripPage2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage2.Size = new System.Drawing.Size(947, 72);
            this.tabStripPage2.Speed = 8;
            this.tabStripPage2.TabIndex = 1;
            // 
            // tab2
            // 
            this.tab2.AutoSize = false;
            this.tab2.Checked = true;
            this.tab2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab2.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(54, 23);
            this.tab2.TabStripPage = this.tabStripPage2;
            this.tab2.Text = "tab2";
            // 
            // tabPanel1
            // 
            this.tabPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabPanel1.BaseColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tabPanel1.Caption = "";
            this.tabPanel1.Controls.Add(this.ribbonButton1);
            this.tabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel1.Location = new System.Drawing.Point(0, 3);
            this.tabPanel1.Name = "tabPanel1";
            this.tabPanel1.Opacity = 255;
            this.tabPanel1.Size = new System.Drawing.Size(947, 69);
            this.tabPanel1.Speed = 1;
            this.tabPanel1.TabIndex = 0;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ribbonButton1.filename = null;
            this.ribbonButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonButton1.FlatAppearance.BorderSize = 0;
            this.ribbonButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonButton1.folder = null;
            this.ribbonButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ribbonButton1.img = null;
            this.ribbonButton1.img_back = null;
            this.ribbonButton1.img_click = null;
            this.ribbonButton1.img_on = null;
            this.ribbonButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(239)))));
            this.ribbonButton1.InfoComment = "";
            this.ribbonButton1.InfoImage = "";
            this.ribbonButton1.InfoTitle = "";
            this.ribbonButton1.Location = new System.Drawing.Point(8, 3);
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Size = new System.Drawing.Size(75, 46);
            this.ribbonButton1.TabIndex = 0;
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ribbonButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 339);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.tabStrip1.ResumeLayout(false);
            this.tabStrip1.PerformLayout();
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage2.ResumeLayout(false);
            this.tabPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage2;
        private RibbonStyle.TabStripPage tabStripPage1;
        private RibbonStyle.TabStrip tabStrip1;
        private RibbonStyle.Tab tab1;
        private RibbonStyle.Tab tab2;
        private RibbonStyle.TabPanel tabPanel1;
        private RibbonStyle.RibbonButton ribbonButton1;

    }
}