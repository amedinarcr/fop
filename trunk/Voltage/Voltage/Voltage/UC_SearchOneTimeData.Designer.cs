namespace Voltage
{
    partial class UC_SearchOneTimeData
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
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDropButton1 = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label1.Location = new System.Drawing.Point(227, 4);
            this.label1.Name = "label1";
            this.label1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间点";
            this.label1.Values.ExtraText = "";
            this.label1.Values.Image = null;
            this.label1.Values.Text = "时间点";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker1.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker1.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.dateTimePicker1.CalendarTodayDate = new System.DateTime(2009, 8, 22, 0, 0, 0, 0);
            this.dateTimePicker1.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // button1
            // 
            this.button1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button1.Location = new System.Drawing.Point(479, 1);
            this.button1.Name = "button1";
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "显示";
            this.button1.Values.ExtraText = "";
            this.button1.Values.Image = null;
            this.button1.Values.ImageStates.ImageCheckedNormal = null;
            this.button1.Values.ImageStates.ImageCheckedPressed = null;
            this.button1.Values.ImageStates.ImageCheckedTracking = null;
            this.button1.Values.Text = "显示";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "采集器编号";
            this.label2.Values.ExtraText = "";
            this.label2.Values.Image = null;
            this.label2.Values.Text = "采集器编号";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDropButton1);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Controls.Add(this.dateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonPanel1.Size = new System.Drawing.Size(880, 27);
            this.kryptonPanel1.TabIndex = 13;
            // 
            // kryptonDropButton1
            // 
            this.kryptonDropButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonDropButton1.Location = new System.Drawing.Point(77, 1);
            this.kryptonDropButton1.Name = "kryptonDropButton1";
            this.kryptonDropButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDropButton1.Size = new System.Drawing.Size(139, 25);
            this.kryptonDropButton1.TabIndex = 28;
            this.kryptonDropButton1.Values.ExtraText = "";
            this.kryptonDropButton1.Values.Image = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonDropButton1.Values.Text = "";
            this.kryptonDropButton1.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs>(this.kryptonDropButton1_DropDown);
            // 
            // UC_SearchOneTimeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "UC_SearchOneTimeData";
            this.Size = new System.Drawing.Size(880, 27);
            this.Load += new System.EventHandler(this.UC_SearchOneTimeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton kryptonDropButton1;
    }
}
