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
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dataTree1 = new Voltage.DataTree();
            this.SuspendLayout();
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit;
            this.buttonSpecAny1.ExtraText = "";
            this.buttonSpecAny1.Image = null;
            this.buttonSpecAny1.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.buttonSpecAny1.Text = "确定";
            this.buttonSpecAny1.UniqueName = "90482297C07A44BD90482297C07A44BD";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit;
            this.buttonSpecAny2.ExtraText = "";
            this.buttonSpecAny2.Image = null;
            this.buttonSpecAny2.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.buttonSpecAny2.Text = "取消";
            this.buttonSpecAny2.UniqueName = "70EC3BE32DE5494D70EC3BE32DE5494D";
            // 
            // dataTree1
            // 
            this.dataTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTree1.Location = new System.Drawing.Point(1, 1);
            this.dataTree1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.dataTree1.Name = "dataTree1";
            this.dataTree1.Padding = new System.Windows.Forms.Padding(3);
            this.dataTree1.Size = new System.Drawing.Size(257, 523);
            this.dataTree1.TabIndex = 1;
            // 
            // GetCollectInfoId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1,
            this.buttonSpecAny2});
            this.ClientSize = new System.Drawing.Size(259, 525);
            this.ControlBox = false;
            this.Controls.Add(this.dataTree1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetCollectInfoId";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取采集器编号";
            this.Load += new System.EventHandler(this.GetCollectInfoId_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private DataTree dataTree1;
    }
}