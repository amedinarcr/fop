namespace Voltage
{
    partial class ChoseOupputDataType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseOupputDataType));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.wizardControl1 = new WizardBase.WizardControl();
            this.startStep1 = new WizardBase.StartStep();
            this.startStep2 = new WizardBase.StartStep();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.finishStep1 = new WizardBase.FinishStep();
            this.label5 = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startStep1.SuspendLayout();
            this.startStep2.SuspendLayout();
            this.finishStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "导出文件格式";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "下一步";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackButtonEnabled = true;
            this.wizardControl1.BackButtonText = "< 返回";
            this.wizardControl1.BackButtonVisible = true;
            this.wizardControl1.CancelButtonEnabled = true;
            this.wizardControl1.CancelButtonText = "取消";
            this.wizardControl1.CancelButtonVisible = true;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.EulaButtonEnabled = true;
            this.wizardControl1.EulaButtonText = "";
            this.wizardControl1.EulaButtonVisible = true;
            this.wizardControl1.FinishButtonText = "完成";
            this.wizardControl1.HelpButtonEnabled = true;
            this.wizardControl1.HelpButtonVisible = false;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextButtonEnabled = true;
            this.wizardControl1.NextButtonText = "下一步 >";
            this.wizardControl1.NextButtonVisible = true;
            this.wizardControl1.Size = new System.Drawing.Size(566, 400);
            this.wizardControl1.WizardSteps.AddRange(new WizardBase.WizardStep[] {
            this.startStep1,
            this.startStep2,
            this.finishStep1});
            this.wizardControl1.NextButtonClick +=new WizardBase.GenericCancelEventHandler<WizardBase.WizardControl>(wizardControl1_NextButtonClick);
            this.wizardControl1.BackButtonClick += new System.ComponentModel.CancelEventHandler(wizardControl1_BackButtonClick);
            this.wizardControl1.FinishButtonClick += new System.EventHandler(this.wizardControl1_FinishButtonClick);
            this.wizardControl1.CancelButtonClick += new System.EventHandler(this.wizardControl1_CancelButtonClick);
            // 
            // startStep1
            // 
            this.startStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep1.BindingImage")));
            this.startStep1.Controls.Add(this.label1);
            this.startStep1.Controls.Add(this.comboBox1);
            this.startStep1.Icon = null;
            this.startStep1.Name = "startStep1";
            this.startStep1.Subtitle = "choose the format of the output file";
            this.startStep1.Title = "选择导出文件格式";
            // 
            // startStep2
            // 
            this.startStep2.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep2.BindingImage")));
            this.startStep2.Controls.Add(this.dateTimePicker_EndTime);
            this.startStep2.Controls.Add(this.label2);
            this.startStep2.Controls.Add(this.label3);
            this.startStep2.Controls.Add(this.dateTimePicker_StartTime);
            this.startStep2.Icon = null;
            this.startStep2.Name = "startStep2";
            this.startStep2.Subtitle = "choose the range of the time";
            this.startStep2.Title = "选择时间范围";
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(248, 155);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(262, 21);
            this.dateTimePicker_EndTime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "开始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "终止时间";
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(248, 117);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(262, 21);
            this.dateTimePicker_StartTime.TabIndex = 8;
            // 
            // finishStep1
            // 
            this.finishStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("finishStep1.BindingImage")));
            this.finishStep1.Controls.Add(this.label5);
            this.finishStep1.Controls.Add(this.label_info);
            this.finishStep1.Controls.Add(this.label4);
            this.finishStep1.Name = "finishStep1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(177, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 34);
            this.label5.TabIndex = 11;
            this.label5.Visible = false;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(230, 247);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 12);
            this.label_info.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(177, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "正在保存数据......";
            // 
            // ChoseOupputDataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 400);
            this.Controls.Add(this.wizardControl1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoseOupputDataType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择导出文件格式";
            this.Load += new System.EventHandler(this.ChoseOupputDataType_Load);
            this.startStep1.ResumeLayout(false);
            this.startStep1.PerformLayout();
            this.startStep2.ResumeLayout(false);
            this.startStep2.PerformLayout();
            this.finishStep1.ResumeLayout(false);
            this.finishStep1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private WizardBase.WizardControl wizardControl1;
        private WizardBase.StartStep startStep1;
        private WizardBase.FinishStep finishStep1;
        private WizardBase.StartStep startStep2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label5;
    }
}