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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBox_CollectId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间点";
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
            this.button1.Location = new System.Drawing.Point(479, 2);
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
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(170, 2);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(44, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "选择";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "选择";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_CollectId
            // 
            this.textBox_CollectId.Enabled = false;
            this.textBox_CollectId.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.textBox_CollectId.Location = new System.Drawing.Point(73, 3);
            this.textBox_CollectId.Name = "textBox_CollectId";
            this.textBox_CollectId.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.textBox_CollectId.Size = new System.Drawing.Size(91, 23);
            this.textBox_CollectId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "采集器编号";
            // 
            // UC_SearchOneTimeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_CollectId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "UC_SearchOneTimeData";
            this.Size = new System.Drawing.Size(880, 27);
            this.Load += new System.EventHandler(this.UC_SearchOneTimeData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_CollectId;
        private System.Windows.Forms.Label label2;
    }
}
