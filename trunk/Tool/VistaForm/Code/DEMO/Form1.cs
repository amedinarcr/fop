using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
 * CopyRight by cici studio 2000-2008
 * 欢迎朋友们和我联系chengchencici@163.com
 * http://www.chengchen.net
 */
namespace DEMO
{
    public partial class Form1 : VistaForm.VistaForm
    {
        private int m_Red;
        private int m_Green;
        private int m_Blue;

        public Form1()
        {
            InitializeComponent();
            m_Red = this.BackColor.R;
            m_Green = this.BackColor.G;
            m_Blue = this.BackColor.B;
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            m_Red = trackBarRed.Value;
            this.BackColor = Color.FromArgb(m_Red, m_Green, m_Blue);
            //Invalidate(false);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            m_Green = trackBarGreen.Value;
            this.BackColor = Color.FromArgb(m_Red, m_Green, m_Blue);
            //Invalidate(false);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            m_Blue = trackBarBlue.Value;
            this.BackColor = Color.FromArgb(m_Red, m_Green, m_Blue);
            //Invalidate(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarRed.Value = m_Red;
            trackBarBlue.Value = m_Blue;
            trackBarGreen.Value = m_Green;
        }


    }
}