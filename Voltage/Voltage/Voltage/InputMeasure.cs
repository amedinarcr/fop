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
                return this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text;
            }
            set
            {
                int index1 = value.IndexOf(',');
                this.textBox1.Text = value.Substring(0, index1);
                int index2=value.IndexOf(',',index1+1);
                this.textBox2.Text = value.Substring(index1 + 1, index2 - index1 - 1);
                this.textBox3.Text = value.Substring(value.LastIndexOf(',') + 1);
            }
        }
    }
}
