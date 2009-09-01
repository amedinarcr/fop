namespace Voltage
{
    partial class UC_DataGridCharting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DataGridCharting));
            this.splitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.button4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_property = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.splitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dataTree1 = new Voltage.DataTree();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.splitContainer1.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button_property);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.splitContainer1.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.splitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.splitContainer1.Size = new System.Drawing.Size(699, 367);
            this.splitContainer1.SplitterDistance = 562;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List;
            this.dataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(556, 361);
            this.dataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button4
            // 
            this.button4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button4.Location = new System.Drawing.Point(13, 129);
            this.button4.Name = "button4";
            this.button4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button4.Size = new System.Drawing.Size(112, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "计算";
            this.button4.Values.ExtraText = "";
            this.button4.Values.Image = null;
            this.button4.Values.ImageStates.ImageCheckedNormal = null;
            this.button4.Values.ImageStates.ImageCheckedPressed = null;
            this.button4.Values.ImageStates.ImageCheckedTracking = null;
            this.button4.Values.Text = "计算";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_property
            // 
            this.button_property.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button_property.Location = new System.Drawing.Point(13, 90);
            this.button_property.Name = "button_property";
            this.button_property.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button_property.Size = new System.Drawing.Size(112, 31);
            this.button_property.TabIndex = 3;
            this.button_property.Text = "设置属性";
            this.button_property.Values.ExtraText = "";
            this.button_property.Values.Image = null;
            this.button_property.Values.ImageStates.ImageCheckedNormal = null;
            this.button_property.Values.ImageStates.ImageCheckedPressed = null;
            this.button_property.Values.ImageStates.ImageCheckedTracking = null;
            this.button_property.Values.Text = "设置属性";
            this.button_property.Visible = false;
            this.button_property.Click += new System.EventHandler(this.button_property_Click);
            // 
            // button3
            // 
            this.button3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button3.Location = new System.Drawing.Point(13, 1);
            this.button3.Name = "button3";
            this.button3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button3.Size = new System.Drawing.Size(112, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "修改";
            this.button3.Values.ExtraText = "";
            this.button3.Values.Image = null;
            this.button3.Values.ImageStates.ImageCheckedNormal = null;
            this.button3.Values.ImageStates.ImageCheckedPressed = null;
            this.button3.Values.ImageStates.ImageCheckedTracking = null;
            this.button3.Values.Text = "修改";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(13, 36);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "删除";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.kryptonHeaderGroup1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.splitContainer2.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.splitContainer2.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.splitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.splitContainer2.Size = new System.Drawing.Size(844, 367);
            this.splitContainer2.SplitterDistance = 140;
            this.splitContainer2.TabIndex = 1;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary;
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonHeaderGroup1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.kryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(3, 3);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dataTree1);
            this.kryptonHeaderGroup1.Panel.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(134, 361);
            this.kryptonHeaderGroup1.TabIndex = 1;
            this.kryptonHeaderGroup1.Text = "采集器编号";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "采集器编号";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Description";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // dataTree1
            // 
            this.dataTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTree1.Location = new System.Drawing.Point(1, 1);
            this.dataTree1.Name = "dataTree1";
            this.dataTree1.Size = new System.Drawing.Size(130, 306);
            this.dataTree1.TabIndex = 0;
            this.dataTree1.Load += new System.EventHandler(this.dataTree1_Load);
            // 
            // UC_DataGridCharting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "UC_DataGridCharting";
            this.Size = new System.Drawing.Size(844, 367);
            this.Load += new System.EventHandler(this.UC_DataGridCharting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2.Panel2)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainer1;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button4;
       
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainer2;
        public DataTree dataTree1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_property;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;

    }
}
