namespace Voltage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Serial = new System.Windows.Forms.ToolStripMenuItem();
            this.校时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取数据RToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清空数据表CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时导出TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘图GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通绘图PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单时间点绘图SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SerialInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_charting = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始SToolStripMenuItem,
            this.数据DToolStripMenuItem,
            this.绘图GToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始SToolStripMenuItem
            // 
            this.开始SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Serial,
            this.校时ToolStripMenuItem,
            this.读取数据RToolStripMenuItem1,
            this.清空数据表CToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.开始SToolStripMenuItem.Name = "开始SToolStripMenuItem";
            this.开始SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.开始SToolStripMenuItem.Text = "硬件(&H)";
            // 
            // MenuItem_Serial
            // 
            this.MenuItem_Serial.Name = "MenuItem_Serial";
            this.MenuItem_Serial.Size = new System.Drawing.Size(147, 22);
            this.MenuItem_Serial.Text = "打开串口(&O)";
            this.MenuItem_Serial.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuItem_Serial.Visible = false;
            this.MenuItem_Serial.Click += new System.EventHandler(this.MenuItem_Serial_Click);
            // 
            // 校时ToolStripMenuItem
            // 
            this.校时ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("校时ToolStripMenuItem.Image")));
            this.校时ToolStripMenuItem.Name = "校时ToolStripMenuItem";
            this.校时ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.校时ToolStripMenuItem.Text = "校时(&T)";
            this.校时ToolStripMenuItem.Click += new System.EventHandler(this.校时ToolStripMenuItem_Click);
            // 
            // 读取数据RToolStripMenuItem1
            // 
            this.读取数据RToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("读取数据RToolStripMenuItem1.Image")));
            this.读取数据RToolStripMenuItem1.Name = "读取数据RToolStripMenuItem1";
            this.读取数据RToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.读取数据RToolStripMenuItem1.Text = "读取数据(R)";
            this.读取数据RToolStripMenuItem1.Click += new System.EventHandler(this.读取数据RToolStripMenuItem1_Click);
            // 
            // 清空数据表CToolStripMenuItem
            // 
            this.清空数据表CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("清空数据表CToolStripMenuItem.Image")));
            this.清空数据表CToolStripMenuItem.Name = "清空数据表CToolStripMenuItem";
            this.清空数据表CToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.清空数据表CToolStripMenuItem.Text = "清空数据表(&C)";
            this.清空数据表CToolStripMenuItem.Click += new System.EventHandler(this.清空数据表CToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.退出EToolStripMenuItem.Text = "退出(E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 数据DToolStripMenuItem
            // 
            this.数据DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出数据OToolStripMenuItem,
            this.导入数据RToolStripMenuItem,
            this.定时导出TToolStripMenuItem});
            this.数据DToolStripMenuItem.Name = "数据DToolStripMenuItem";
            this.数据DToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.数据DToolStripMenuItem.Text = "数据(&D)";
            // 
            // 导出数据OToolStripMenuItem
            // 
            this.导出数据OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导出数据OToolStripMenuItem.Image")));
            this.导出数据OToolStripMenuItem.Name = "导出数据OToolStripMenuItem";
            this.导出数据OToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.导出数据OToolStripMenuItem.Text = "导出数据(&O)";
            this.导出数据OToolStripMenuItem.Click += new System.EventHandler(this.导出数据OToolStripMenuItem_Click);
            // 
            // 导入数据RToolStripMenuItem
            // 
            this.导入数据RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导入数据RToolStripMenuItem.Image")));
            this.导入数据RToolStripMenuItem.Name = "导入数据RToolStripMenuItem";
            this.导入数据RToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.导入数据RToolStripMenuItem.Text = "导入数据(&R)";
            this.导入数据RToolStripMenuItem.Click += new System.EventHandler(this.导入数据RToolStripMenuItem_Click);
            // 
            // 定时导出TToolStripMenuItem
            // 
            this.定时导出TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("定时导出TToolStripMenuItem.Image")));
            this.定时导出TToolStripMenuItem.Name = "定时导出TToolStripMenuItem";
            this.定时导出TToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.定时导出TToolStripMenuItem.Text = "定时导出设置(&T)";
            this.定时导出TToolStripMenuItem.Click += new System.EventHandler(this.定时导出TToolStripMenuItem_Click);
            // 
            // 绘图GToolStripMenuItem
            // 
            this.绘图GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通绘图PToolStripMenuItem,
            this.单时间点绘图SToolStripMenuItem});
            this.绘图GToolStripMenuItem.Name = "绘图GToolStripMenuItem";
            this.绘图GToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.绘图GToolStripMenuItem.Text = "绘图(&G)";
            // 
            // 普通绘图PToolStripMenuItem
            // 
            this.普通绘图PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("普通绘图PToolStripMenuItem.Image")));
            this.普通绘图PToolStripMenuItem.Name = "普通绘图PToolStripMenuItem";
            this.普通绘图PToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.普通绘图PToolStripMenuItem.Text = "普通绘图(&P)";
            this.普通绘图PToolStripMenuItem.Click += new System.EventHandler(this.普通绘图PToolStripMenuItem_Click);
            // 
            // 单时间点绘图SToolStripMenuItem
            // 
            this.单时间点绘图SToolStripMenuItem.Image = global::Voltage.Properties.Resources._03886;
            this.单时间点绘图SToolStripMenuItem.Name = "单时间点绘图SToolStripMenuItem";
            this.单时间点绘图SToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.单时间点绘图SToolStripMenuItem.Text = "单时间点绘图(&S)";
            this.单时间点绘图SToolStripMenuItem.Click += new System.EventHandler(this.单时间点绘图SToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerialInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SerialInfo
            // 
            this.SerialInfo.Name = "SerialInfo";
            this.SerialInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "校时";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton2.Text = "读取数据";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton3.Text = "清空数据";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton4.Text = "导出数据";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton5.Text = "导入数据";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton6.Text = "定时导出设置";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton7.Text = "普通绘图";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton8.Text = "单时间点绘图";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_charting);
            this.splitContainer1.Size = new System.Drawing.Size(993, 486);
            this.splitContainer1.SplitterDistance = 0;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel_charting
            // 
            this.panel_charting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_charting.Location = new System.Drawing.Point(0, 0);
            this.panel_charting.Name = "panel_charting";
            this.panel_charting.Size = new System.Drawing.Size(993, 485);
            this.panel_charting.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 557);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "阴极保护电位自动采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据DToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据RToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_charting;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Serial;
        private System.Windows.Forms.ToolStripMenuItem 校时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取数据RToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清空数据表CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘图GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通绘图PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单时间点绘图SToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定时导出TToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripStatusLabel SerialInfo;
    }
}