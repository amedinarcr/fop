﻿namespace Voltage
{
    partial class DataCharting
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
            dotnetCHARTING.WinForms.Label label1 = new dotnetCHARTING.WinForms.Label();
            this.chart1 = new dotnetCHARTING.WinForms.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Background.Color = System.Drawing.Color.White;
            this.chart1.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.chart1.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chart1.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.chart1.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.chart1.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.chart1.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.Padding = 4;
            this.chart1.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.chart1.ChartArea.LegendBox.Visible = true;
            this.chart1.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.chart1.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chart1.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.TitleBox.Visible = true;
            this.chart1.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.chart1.DataGrid = null;
            this.chart1.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.LabelChart = label1;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.NoDataLabel.Text = "No Data";
            this.chart1.Size = new System.Drawing.Size(805, 351);
            this.chart1.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.TabIndex = 0;
            this.chart1.TempDirectory = "C:\\Documents and Settings\\Administrator\\Local Settings\\Temp\\";
            this.chart1.Load += new System.EventHandler(this.chart1_Load);
            // 
            // DataCharting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Name = "DataCharting";
            this.Size = new System.Drawing.Size(805, 351);
            this.Load += new System.EventHandler(this.DataCharting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dotnetCHARTING.WinForms.Chart chart1;
    }
}
