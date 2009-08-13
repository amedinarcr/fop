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
            this.绘图GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通绘图PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单时间点绘图SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_charting = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.开始SToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.开始SToolStripMenuItem.Text = "硬件(&H)";
            // 
            // MenuItem_Serial
            // 
            this.MenuItem_Serial.Name = "MenuItem_Serial";
            this.MenuItem_Serial.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Serial.Text = "打开串口(&O)";
            this.MenuItem_Serial.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // 校时ToolStripMenuItem
            // 
            this.校时ToolStripMenuItem.Name = "校时ToolStripMenuItem";
            this.校时ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.校时ToolStripMenuItem.Text = "校时(&T)";
            this.校时ToolStripMenuItem.Click += new System.EventHandler(this.校时ToolStripMenuItem_Click);
            // 
            // 读取数据RToolStripMenuItem1
            // 
            this.读取数据RToolStripMenuItem1.Name = "读取数据RToolStripMenuItem1";
            this.读取数据RToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.读取数据RToolStripMenuItem1.Text = "读取数据(R)";
            this.读取数据RToolStripMenuItem1.Click += new System.EventHandler(this.读取数据RToolStripMenuItem1_Click);
            // 
            // 清空数据表CToolStripMenuItem
            // 
            this.清空数据表CToolStripMenuItem.Name = "清空数据表CToolStripMenuItem";
            this.清空数据表CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清空数据表CToolStripMenuItem.Text = "清空数据表(&C)";
            this.清空数据表CToolStripMenuItem.Click += new System.EventHandler(this.清空数据表CToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出EToolStripMenuItem.Text = "退出(E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 数据DToolStripMenuItem
            // 
            this.数据DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出数据OToolStripMenuItem,
            this.导入数据RToolStripMenuItem});
            this.数据DToolStripMenuItem.Name = "数据DToolStripMenuItem";
            this.数据DToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.数据DToolStripMenuItem.Text = "数据(&D)";
            // 
            // 导出数据OToolStripMenuItem
            // 
            this.导出数据OToolStripMenuItem.Name = "导出数据OToolStripMenuItem";
            this.导出数据OToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导出数据OToolStripMenuItem.Text = "导出数据(&O)";
            this.导出数据OToolStripMenuItem.Click += new System.EventHandler(this.导出数据OToolStripMenuItem_Click);
            // 
            // 导入数据RToolStripMenuItem
            // 
            this.导入数据RToolStripMenuItem.Name = "导入数据RToolStripMenuItem";
            this.导入数据RToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导入数据RToolStripMenuItem.Text = "导入数据(&R)";
            this.导入数据RToolStripMenuItem.Click += new System.EventHandler(this.导入数据RToolStripMenuItem_Click);
            // 
            // 绘图GToolStripMenuItem
            // 
            this.绘图GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通绘图PToolStripMenuItem,
            this.单时间点绘图SToolStripMenuItem});
            this.绘图GToolStripMenuItem.Name = "绘图GToolStripMenuItem";
            this.绘图GToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.绘图GToolStripMenuItem.Text = "绘图(&G)";
            // 
            // 普通绘图PToolStripMenuItem
            // 
            this.普通绘图PToolStripMenuItem.Name = "普通绘图PToolStripMenuItem";
            this.普通绘图PToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.普通绘图PToolStripMenuItem.Text = "普通绘图(&P)";
            this.普通绘图PToolStripMenuItem.Click += new System.EventHandler(this.普通绘图PToolStripMenuItem_Click);
            // 
            // 单时间点绘图SToolStripMenuItem
            // 
            this.单时间点绘图SToolStripMenuItem.Name = "单时间点绘图SToolStripMenuItem";
            this.单时间点绘图SToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.单时间点绘图SToolStripMenuItem.Text = "单时间点绘图(&S)";
            this.单时间点绘图SToolStripMenuItem.Click += new System.EventHandler(this.单时间点绘图SToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            this.splitContainer1.Size = new System.Drawing.Size(993, 443);
            this.splitContainer1.SplitterDistance = 0;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel_charting
            // 
            this.panel_charting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_charting.Location = new System.Drawing.Point(0, 0);
            this.panel_charting.Name = "panel_charting";
            this.panel_charting.Size = new System.Drawing.Size(993, 442);
            this.panel_charting.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 514);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "阴极保护电位自动采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}