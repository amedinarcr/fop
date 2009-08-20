namespace WizardDemo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.licenceStep1 = new WizardBase.LicenceStep();
            this.finishStep1 = new WizardBase.FinishStep();
            this.wizardControl1 = new WizardBase.WizardControl();
            this.licenceStep2 = new WizardBase.LicenceStep();
            this.startStep1 = new WizardBase.StartStep();
            this.intermediateStep1 = new WizardBase.IntermediateStep();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.finishStep2 = new WizardBase.FinishStep();
            this.intermediateStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // licenceStep1
            // 
            this.licenceStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("licenceStep1.BindingImage")));
            this.licenceStep1.LicenseFile = "";
            this.licenceStep1.Name = "licenceStep1";
            this.licenceStep1.Title = "License Agreement.";
            this.licenceStep1.Warning = "Please read the following license agreement. You must accept the terms  of this a" +
                "greement before continuing.";
            this.licenceStep1.WarningFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // finishStep1
            // 
            this.finishStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("finishStep1.BindingImage")));
            this.finishStep1.Name = "finishStep1";
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackButtonEnabled = false;
            this.wizardControl1.BackButtonVisible = true;
            this.wizardControl1.CancelButtonEnabled = true;
            this.wizardControl1.CancelButtonVisible = true;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.EulaButtonEnabled = true;
            this.wizardControl1.EulaButtonText = "";
            this.wizardControl1.EulaButtonVisible = true;
            this.wizardControl1.HelpButtonEnabled = true;
            this.wizardControl1.HelpButtonVisible = true;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextButtonEnabled = true;
            this.wizardControl1.NextButtonVisible = true;
            this.wizardControl1.Size = new System.Drawing.Size(657, 456);
            this.wizardControl1.WizardSteps.AddRange(new WizardBase.WizardStep[] {
            this.startStep1,
            this.intermediateStep1,
            this.finishStep2});
            // 
            // licenceStep2
            // 
            this.licenceStep2.BindingImage = ((System.Drawing.Image)(resources.GetObject("licenceStep2.BindingImage")));
            this.licenceStep2.LicenseFile = "";
            this.licenceStep2.Name = "licenceStep2";
            this.licenceStep2.Title = "License Agreement.";
            this.licenceStep2.Warning = "Please read the following license agreement. You must accept the terms  of this a" +
                "greement before continuing.";
            this.licenceStep2.WarningFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // startStep1
            // 
            this.startStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep1.BindingImage")));
            this.startStep1.Icon = ((System.Drawing.Image)(resources.GetObject("startStep1.Icon")));
            this.startStep1.Name = "startStep1";
            // 
            // intermediateStep1
            // 
            this.intermediateStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("intermediateStep1.BindingImage")));
            this.intermediateStep1.Controls.Add(this.simpleButton1);
            this.intermediateStep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.intermediateStep1.Name = "intermediateStep1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(84, 131);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(203, 54);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // finishStep2
            // 
            this.finishStep2.BindingImage = ((System.Drawing.Image)(resources.GetObject("finishStep2.BindingImage")));
            this.finishStep2.Name = "finishStep2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 456);
            this.Controls.Add(this.wizardControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.intermediateStep1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WizardBase.LicenceStep licenceStep1;
        private WizardBase.FinishStep finishStep1;
        private WizardBase.WizardControl wizardControl1;
        private WizardBase.LicenceStep licenceStep2;
        private WizardBase.StartStep startStep1;
        private WizardBase.IntermediateStep intermediateStep1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private WizardBase.FinishStep finishStep2;
    }
}