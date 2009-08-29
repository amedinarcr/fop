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
        private int LongOrLat;
        public InputMeasure()
        {
            InitializeComponent();
            
        }
        public InputMeasure(int LongOrLat)
        {
            this.LongOrLat = LongOrLat;
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
        private void textBox1_Validating(object sender, EventArgs e)
        {
            if (this.LongOrLat==1)
            {
                if (Convert.ToInt32(this.textBox1.Text) < -180 || Convert.ToInt32(this.textBox1.Text)>180)
	            {
		            MessageBox.Show("输入格式不正确");
                    this.textBox1.Text=string.Empty;
                    this.textBox1.Focus();
	            }
                
            }
            else if (this.LongOrLat == 2)
	        {
                if (Convert.ToInt32(this.textBox1.Text) < -90 || Convert.ToInt32(this.textBox1.Text) > 90)
                {
                    MessageBox.Show("输入格式不正确");
                    this.textBox1.Text = string.Empty;
                    this.textBox1.Focus();
                }
	        }
        }

        private void textBox2_Validating(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.textBox2.Text) < 0 || Convert.ToInt32(this.textBox1.Text)>60)
            {
                MessageBox.Show("输入格式不正确");
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
            }

        }

        private void textBox3_Validating(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.textBox3.Text) < 0 || Convert.ToInt32(this.textBox3.Text) > 60)
            {
                MessageBox.Show("输入格式不正确");
                this.textBox3.Text = string.Empty;
                this.textBox3.Focus();
            }
        }
    }
}
