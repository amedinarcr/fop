namespace VistaForm
{
    partial class VistaForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackgroundImage = global::VistaForm.Properties.Resources.Top;
            this.pictureBoxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMax.Image = global::VistaForm.Properties.Resources.Max;
            this.pictureBoxMax.Location = new System.Drawing.Point(329, 0);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(26, 16);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMax.TabIndex = 2;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.MouseLeave += new System.EventHandler(this.pictureBoxMax_MouseLeave);
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            this.pictureBoxMax.MouseEnter += new System.EventHandler(this.pictureBoxMax_MouseEnter);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackgroundImage = global::VistaForm.Properties.Resources.Top;
            this.pictureBoxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMin.Image = global::VistaForm.Properties.Resources.Min;
            this.pictureBoxMin.Location = new System.Drawing.Point(305, 0);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(27, 16);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMin.TabIndex = 1;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = global::VistaForm.Properties.Resources.Top;
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClose.Image = global::VistaForm.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(352, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(42, 16);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
            // 
            // VistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 323);
            this.Controls.Add(this.pictureBoxMax);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaForm";
            this.Text = "VistaForm";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VistaForm_MouseDoubleClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaForm_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VistaForm_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaForm_MouseDown);
            this.Load += new System.EventHandler(this.VistaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMax;

    }
}

