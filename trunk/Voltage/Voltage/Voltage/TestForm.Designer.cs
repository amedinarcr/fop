namespace Voltage
{
    partial class TestForm
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
            this.inputMeasure1 = new Voltage.InputMeasure();
            this.dataTree1 = new Voltage.DataTree();
            this.SuspendLayout();
            // 
            // inputMeasure1
            // 
            this.inputMeasure1.Location = new System.Drawing.Point(183, 12);
            this.inputMeasure1.Name = "inputMeasure1";
            this.inputMeasure1.Size = new System.Drawing.Size(195, 21);
            this.inputMeasure1.TabIndex = 1;
            // 
            // dataTree1
            // 
            this.dataTree1.Location = new System.Drawing.Point(12, 12);
            this.dataTree1.Name = "dataTree1";
            this.dataTree1.Size = new System.Drawing.Size(146, 572);
            this.dataTree1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 596);
            this.Controls.Add(this.inputMeasure1);
            this.Controls.Add(this.dataTree1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DataTree dataTree1;
        private InputMeasure inputMeasure1;
    }
}