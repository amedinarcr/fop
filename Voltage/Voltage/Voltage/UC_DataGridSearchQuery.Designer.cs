namespace Voltage
{
    partial class UC_DataGridSearchQuery
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
            this.dateTimePicker_EndTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_StartTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDropButton1 = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.SuspendLayout();
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_EndTime.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_EndTime.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.dateTimePicker_EndTime.CalendarTodayDate = new System.DateTime(2009, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker_EndTime.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(481, 3);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker_EndTime.TabIndex = 13;
            this.dateTimePicker_EndTime.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "终止时间";
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_StartTime.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_StartTime.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.dateTimePicker_StartTime.CalendarTodayDate = new System.DateTime(2009, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker_StartTime.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(271, 3);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker_StartTime.TabIndex = 11;
            this.dateTimePicker_StartTime.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "开始时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "采集器编号";
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(639, 2);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "显示";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "显示";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kryptonDropButton1
            // 
            this.kryptonDropButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonDropButton1.Location = new System.Drawing.Point(67, 2);
            this.kryptonDropButton1.Name = "kryptonDropButton1";
            this.kryptonDropButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDropButton1.Size = new System.Drawing.Size(139, 25);
            this.kryptonDropButton1.TabIndex = 27;
            this.kryptonDropButton1.Values.ExtraText = "";
            this.kryptonDropButton1.Values.Image = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonDropButton1.Values.Text = "";
            this.kryptonDropButton1.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs>(this.kryptonDropButton1_DropDown);
            // 
            // UC_DataGridSearchQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDropButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_DataGridSearchQuery";
            this.Size = new System.Drawing.Size(821, 28);
            this.Load += new System.EventHandler(this.UC_DataGridSearchQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton kryptonDropButton1;
    }
}
