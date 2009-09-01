namespace Voltage
{
    partial class GetDataArithmetic
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
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dateTimePicker_EndTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateTimePicker_StartTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDropButton1 = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.管线名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.button2.Location = new System.Drawing.Point(456, 45);
            this.button2.Name = "button2";
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "计算";
            this.button2.Values.ExtraText = "";
            this.button2.Values.Image = null;
            this.button2.Values.ImageStates.ImageCheckedNormal = null;
            this.button2.Values.ImageStates.ImageCheckedPressed = null;
            this.button2.Values.ImageStates.ImageCheckedTracking = null;
            this.button2.Values.Text = "计算";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_EndTime.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_EndTime.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.dateTimePicker_EndTime.CalendarTodayDate = new System.DateTime(2009, 8, 22, 0, 0, 0, 0);
            this.dateTimePicker_EndTime.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(294, 47);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(152, 21);
            this.dateTimePicker_EndTime.TabIndex = 25;
            this.dateTimePicker_EndTime.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // label3
            // 
            this.label3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label3.Location = new System.Drawing.Point(230, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "终止时间";
            this.label3.Values.ExtraText = "";
            this.label3.Values.Image = null;
            this.label3.Values.Text = "终止时间";
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_StartTime.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.dateTimePicker_StartTime.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.dateTimePicker_StartTime.CalendarTodayDate = new System.DateTime(2009, 8, 22, 0, 0, 0, 0);
            this.dateTimePicker_StartTime.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(73, 47);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker_StartTime.TabIndex = 19;
            this.dateTimePicker_StartTime.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // label2
            // 
            this.label2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "开始时间";
            this.label2.Values.ExtraText = "";
            this.label2.Values.Image = null;
            this.label2.Values.Text = "开始时间";
            // 
            // label1
            // 
            this.label1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "采集器编号";
            this.label1.Values.ExtraText = "";
            this.label1.Values.Image = null;
            this.label1.Values.Text = "采集器编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.管线名称,
            this.CollectId,
            this.Average,
            this.Variance});
            this.dataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List;
            this.dataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.dataGridView1.Location = new System.Drawing.Point(10, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 185);
            this.dataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.TabIndex = 25;
            // 
            // kryptonDropButton1
            // 
            this.kryptonDropButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonDropButton1.Location = new System.Drawing.Point(73, 12);
            this.kryptonDropButton1.Name = "kryptonDropButton1";
            this.kryptonDropButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDropButton1.Size = new System.Drawing.Size(214, 25);
            this.kryptonDropButton1.TabIndex = 26;
            this.kryptonDropButton1.Values.ExtraText = "";
            this.kryptonDropButton1.Values.Image = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonDropButton1.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonDropButton1.Values.Text = "";
            this.kryptonDropButton1.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs>(this.button1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDropButton1);
            this.kryptonPanel1.Controls.Add(this.dataGridView1);
            this.kryptonPanel1.Controls.Add(this.button2);
            this.kryptonPanel1.Controls.Add(this.dateTimePicker_EndTime);
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.dateTimePicker_StartTime);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonPanel1.Size = new System.Drawing.Size(545, 273);
            this.kryptonPanel1.TabIndex = 27;
            // 
            // 管线名称
            // 
            this.管线名称.HeaderText = "管线名称";
            this.管线名称.Name = "管线名称";
            this.管线名称.ReadOnly = true;
            // 
            // CollectId
            // 
            this.CollectId.HeaderText = "采集器编号";
            this.CollectId.Name = "CollectId";
            this.CollectId.ReadOnly = true;
            // 
            // Average
            // 
            this.Average.HeaderText = "平均值";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            // 
            // Variance
            // 
            this.Variance.HeaderText = "方差";
            this.Variance.Name = "Variance";
            this.Variance.ReadOnly = true;
            // 
            // GetDataArithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 273);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetDataArithmetic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "计算均值及方差";
            this.Load += new System.EventHandler(this.GetDataArithmetic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker_EndTime;
        
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker_StartTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton kryptonDropButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管线名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variance;
    }
}