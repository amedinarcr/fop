namespace Voltage
{
    partial class InputData
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
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_DataExist = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "关闭";
            this.button1.UseMnemonic = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "导入";
            this.button2.UseMnemonic = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(488, 273);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "导入文件";
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(73, 12);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(269, 25);
            this.textBox_fileName.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "选择文件";
            this.button3.UseMnemonic = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据存在时";
            this.label4.Visible = false;
            // 
            // comboBox_DataExist
            // 
            this.comboBox_DataExist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DataExist.FormattingEnabled = true;
            this.comboBox_DataExist.Items.AddRange(new object[] {
            "不覆盖数据",
            "覆盖数据"});
            this.comboBox_DataExist.Location = new System.Drawing.Point(85, 338);
            this.comboBox_DataExist.Name = "comboBox_DataExist";
            this.comboBox_DataExist.Size = new System.Drawing.Size(80, 20);
            this.comboBox_DataExist.TabIndex = 10;
            this.comboBox_DataExist.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 11;
            this.button4.Text = "导入";
            this.button4.UseMnemonic = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 333);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox_DataExist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "导入数据";
            this.Load += new System.EventHandler(this.InputData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_fileName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBox_DataExist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button4;

    }
}