namespace Voltage
{
    partial class GetCollectInfoId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetCollectInfoId));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.buttonSpecHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.dataTree1 = new Voltage.DataTree();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1,
            this.buttonSpecHeaderGroup2});
            this.kryptonHeaderGroup1.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary;
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonHeaderGroup1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.kryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(1, 1);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dataTree1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(257, 483);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.Text = "采集器编号";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "采集器编号";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit;
            this.buttonSpecHeaderGroup1.ExtraText = "";
            this.buttonSpecHeaderGroup1.Image = null;
            this.buttonSpecHeaderGroup1.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.buttonSpecHeaderGroup1.Text = "确定";
            this.buttonSpecHeaderGroup1.UniqueName = "4E9B56E48EC24D414E9B56E48EC24D41";
            // 
            // buttonSpecHeaderGroup2
            // 
            this.buttonSpecHeaderGroup2.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit;
            this.buttonSpecHeaderGroup2.ExtraText = "";
            this.buttonSpecHeaderGroup2.Image = null;
            this.buttonSpecHeaderGroup2.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.buttonSpecHeaderGroup2.Text = "取消";
            this.buttonSpecHeaderGroup2.UniqueName = "C3547F7AED554323C3547F7AED554323";
            // 
            // dataTree1
            // 
            this.dataTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTree1.Location = new System.Drawing.Point(0, 0);
            this.dataTree1.Margin = new System.Windows.Forms.Padding(10);
            this.dataTree1.Name = "dataTree1";
            this.dataTree1.Padding = new System.Windows.Forms.Padding(3);
            this.dataTree1.Size = new System.Drawing.Size(255, 448);
            this.dataTree1.TabIndex = 2;
            // 
            // GetCollectInfoId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 485);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetCollectInfoId";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取采集器编号";
            this.Load += new System.EventHandler(this.GetCollectInfoId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup2;
        private DataTree dataTree1;
    }
}