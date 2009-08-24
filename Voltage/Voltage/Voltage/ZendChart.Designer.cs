namespace Voltage
{
    partial class ZendChart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZendChart));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._button1 = new System.Windows.Forms.Button();
            this._button_ShowHidden = new System.Windows.Forms.Button();
            this._comboBox_CollectId = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.uC_DataGridSearchQuery1 = new Voltage.UC_DataGridSearchQuery();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.comboBox_CollectId = new System.Windows.Forms.ToolStripComboBox();
            this.button_ShowHidden = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox4.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._button1);
            this.groupBox4.Controls.Add(this._button_ShowHidden);
            this.groupBox4.Controls.Add(this._comboBox_CollectId);
            this.groupBox4.Location = new System.Drawing.Point(822, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 93);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "基本属性";
            // 
            // _button1
            // 
            this._button1.Location = new System.Drawing.Point(106, 55);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(75, 21);
            this._button1.TabIndex = 5;
            this._button1.Text = "属性";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _button_ShowHidden
            // 
            this._button_ShowHidden.Location = new System.Drawing.Point(7, 55);
            this._button_ShowHidden.Name = "_button_ShowHidden";
            this._button_ShowHidden.Size = new System.Drawing.Size(75, 21);
            this._button_ShowHidden.TabIndex = 4;
            this._button_ShowHidden.Text = "button1";
            this._button_ShowHidden.UseVisualStyleBackColor = true;
            this._button_ShowHidden.Click += new System.EventHandler(this.button_ShowHidden_Click);
            // 
            // _comboBox_CollectId
            // 
            this._comboBox_CollectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox_CollectId.FormattingEnabled = true;
            this._comboBox_CollectId.Location = new System.Drawing.Point(7, 22);
            this._comboBox_CollectId.Name = "_comboBox_CollectId";
            this._comboBox_CollectId.Size = new System.Drawing.Size(174, 20);
            this._comboBox_CollectId.TabIndex = 3;
            this._comboBox_CollectId.SelectedIndexChanged += new System.EventHandler(this.comboBox_CollectId_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uC_DataGridSearchQuery1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGraphControl1);
            this.splitContainer2.Size = new System.Drawing.Size(978, 485);
            this.splitContainer2.SplitterDistance = 44;
            this.splitContainer2.TabIndex = 1;
            // 
            // uC_DataGridSearchQuery1
            // 
            this.uC_DataGridSearchQuery1.Location = new System.Drawing.Point(3, 9);
            this.uC_DataGridSearchQuery1.Name = "uC_DataGridSearchQuery1";
            this.uC_DataGridSearchQuery1.Size = new System.Drawing.Size(978, 28);
            this.uC_DataGridSearchQuery1.TabIndex = 0;
            this.uC_DataGridSearchQuery1.Load += new System.EventHandler(this.uC_DataGridSearchQuery1_Load);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(978, 437);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.comboBox_CollectId,
            this.button_ShowHidden,
            this.button1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton1.Text = "保存到剪切板";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton2.Text = "保存到文件";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton3.Text = "取消上一步缩放";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton4.Text = "取消所有缩放";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton5.Text = "打印设置";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton6.Text = "打印预览";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton7.Text = "打印";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // comboBox_CollectId
            // 
            this.comboBox_CollectId.Name = "comboBox_CollectId";
            this.comboBox_CollectId.Size = new System.Drawing.Size(121, 25);
            this.comboBox_CollectId.SelectedIndexChanged +=new System.EventHandler(comboBox_CollectId_SelectedIndexChanged);
            // 
            // button_ShowHidden
            // 
            this.button_ShowHidden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_ShowHidden.Image = ((System.Drawing.Image)(resources.GetObject("button_ShowHidden.Image")));
            this.button_ShowHidden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_ShowHidden.Name = "button_ShowHidden";
            this.button_ShowHidden.Size = new System.Drawing.Size(35, 22);
            this.button_ShowHidden.Text = "隐藏";
            this.button_ShowHidden.Click += new System.EventHandler(this.button_ShowHidden_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button1
            // 
            this.button1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 22);
            this.button1.Text = "   属性   ";
            this.button1.Click +=new System.EventHandler(button1_Click);
            // 
            // ZendChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer2);
            this.Name = "ZendChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "绘图";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _button1;
        private System.Windows.Forms.Button _button_ShowHidden;
        private System.Windows.Forms.ComboBox _comboBox_CollectId;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UC_DataGridSearchQuery uC_DataGridSearchQuery1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripComboBox comboBox_CollectId;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStripButton button_ShowHidden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton button1;

    }
}