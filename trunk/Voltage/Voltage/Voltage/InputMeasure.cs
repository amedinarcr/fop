using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class InputMeasure : UserControl
    {
        public InputMeasure()
        {
            InitializeComponent();
        }

        private void InputMeasure_Load(object sender, EventArgs e)
        {

        }
        public override string Text
        {
            get
            {
                return this.textBox1.Text + "." + this.textBox2.Text + "." + this.textBox3.Text;
            }
            set
            {
                int duIndex=value.IndexOf('.');
                int fenIndex=value.IndexOf('.',duIndex+1);
                this.textBox1.Text = value.Substring(0,duIndex );
                this.textBox2.Text = value.Substring(duIndex + 1, fenIndex - duIndex - 1);
                this.textBox3.Text = value.Substring(fenIndex + 1);
            }
        }
  
    }
}
