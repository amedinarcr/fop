using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VistaForm
{
    /*
     * CopyRight by cici studio 2000-2008
     * 欢迎朋友们和我联系chengchencici@163.com
     * http://www.chengchen.net
     */
    
    public partial class VistaForm : Form
    {
        #region Fields
        private Image m_LeftTop;
        private Image m_Top;
        private Image m_RightTop;
        private Image m_Left;
        private Image m_Right;
        private Image m_LeftBottom;
        private Image m_Bottom;
        private Image m_RightBottom;

        //窗体边缘的宽度
        private int m_FormEdge = 5;
    
        /// <summary>
        /// 窗体边缘的宽度
        /// </summary>
        [Description("设定边框的实际宽度，鼠标根据该宽度判断何时可以变换形状。"), Category("Vista风格设置(by cici)")]
        public int FormEdge
        {
            get { return m_FormEdge; }
            set { m_FormEdge = value; }
        }

        private Point m_MouseOffset;

        /// <summary>
        /// 是否正在调整界面大小
        /// </summary>
        private bool b_IsChangingSize = false;
        /// <summary>
        /// 是否按下鼠标
        /// </summary>
        private bool b_IsMouseDown = false;

        /// <summary>
        /// 是否正在拖动窗体，如果正在拖动就不准调整大小
        /// </summary>
        private bool b_IsMoveForm = false;

        private VistaMousePosition m_MousePosition = VistaMousePosition.NORMAL;

        //private Color m_BackGroundColor;      
        ///// <summary>
        ///// 背景色
        ///// </summary>
        //[Description("设定主界面的背景色"), Category("Vista风格设置(by cici)")]
        //public Color BackGroundColor
        //{
        //    get { return m_BackGroundColor; }
        //    set { m_BackGroundColor = value; }
        //}

        #endregion
        public VistaForm()
        {
            InitializeComponent();
            InitImages();
           // m_BackGroundColor = this.BackColor;
        }

        #region 画界面
        /// <summary>
        /// 将所有图片载入
        /// </summary>
        private void InitImages()
        {
            m_Top = Properties.Resources.Top;
            m_LeftTop = Properties.Resources.LEFTTOP;
            m_RightTop = Properties.Resources.RIGHTTOP;
            m_Left = Properties.Resources.LEFT;
            m_Right = Properties.Resources.RIGHT;
            m_LeftBottom = Properties.Resources.LeftBottom;
            m_Bottom = Properties.Resources.BOTTOM;
            m_RightBottom = Properties.Resources.RightBottom;
        }

        /// <summary>
        /// 画左上角
        /// </summary>
        /// <param name="graph"></param>
        private void DrawLeftTop(Graphics graph)
        {
            Brush brush = new TextureBrush(m_LeftTop, new Rectangle(0, 0, m_LeftTop.Width, m_LeftTop.Height));
            graph.FillRectangle(brush, 0, 0, m_LeftTop.Width, m_LeftTop.Height);
        }

        /// <summary>
        /// 画最上面
        /// </summary>
        /// <param name="graph"></param>
        private void DrawTop(Graphics graph)
        {
            //渐变的效果？？
            //Rectangle rect = new Rectangle(7, 0, this.Width - 7 * 2, m_Top.Height);
            //graph.DrawImage(m_Top, rect);

            Brush brush = new TextureBrush(m_Top, new Rectangle(0, 0, m_Top.Width, m_Top.Height));
            graph.FillRectangle(brush, m_Left.Width, 0, this.Width - m_Left.Width - m_Right.Width, m_Top.Height);
        }

        /// <summary>
        /// 画右上角
        /// </summary>
        /// <param name="graph"></param>
        private void DrawRightTop(Graphics graph)
        {
            TextureBrush brush = new TextureBrush(m_RightTop, new Rectangle(0, 0, m_RightTop.Width, m_RightTop.Height));
            brush.TranslateTransform(this.Width - m_RightTop.Width, 0); 
            graph.FillRectangle(brush, this.Width - m_RightTop.Width, 0, m_RightTop.Width, m_RightTop.Height);
        }

        /// <summary>
        /// 画左边
        /// </summary>
        /// <param name="graph"></param>
        private void DrawLeft(Graphics graph)
        {
            Brush brush = new TextureBrush(m_Left, new Rectangle(0, 0, m_Left.Width, m_Left.Height));
            graph.FillRectangle(brush, 0, m_LeftTop.Height, m_LeftTop.Width, this.Height - m_LeftBottom.Height - m_LeftTop.Height);
        }

        /// <summary>
        /// 画右边
        /// </summary>
        private void DrawRight(Graphics graph)
        {
            TextureBrush brush = new TextureBrush(m_Right, new Rectangle(0, 0, m_Right.Width, m_Right.Height));
            brush.TranslateTransform(this.Width - m_Right.Width, m_RightTop.Height); 
            graph.FillRectangle(brush, this.Width - m_Right.Width, m_RightTop.Height, m_RightTop.Width, this.Height - m_RightBottom.Height - m_RightTop.Height);
            //graph.DrawImage(m_Right, this.Width - m_Right.Width, m_RightTop.Height, m_RightTop.Width, this.Height - m_RightBottom.Height - m_RightTop.Height);
        }

        /// <summary>
        /// 画左下角
        /// </summary>
        /// <param name="graph"></param>
        private void DrawLeftBottom(Graphics graph)
        {
            //Brush brush = new TextureBrush(m_LeftBottom, new Rectangle(0, 0, m_LeftBottom.Width, m_LeftBottom.Height));
            //graph.FillRectangle(brush, 0, this.Height - m_LeftBottom.Height, m_LeftBottom.Width, this.Height);
            graph.DrawImage(m_LeftBottom,0, this.Height - m_LeftBottom.Height, m_LeftBottom.Width, m_LeftBottom.Height);
        }

        /// <summary>
        /// 画下边
        /// </summary>
        /// <param name="graph"></param>
        private void DrawBottom(Graphics graph)
        {
            //纹理刷
            //TextureBrush brush = new TextureBrush(m_Bottom);
            //graph.FillRectangle(brush, m_LeftBottom.Width, this.Height - m_Bottom.Height, this.Width - m_RightBottom.Width - m_LeftBottom.Width, m_Bottom.Height);
            //Rectangle rect = new Rectangle( m_LeftBottom.Width, this.Height - m_Bottom.Height, this.Width - m_RightBottom.Width - m_LeftBottom.Width, m_Bottom.Height);
            //GraphicsUnit units = GraphicsUnit.Pixel;
            //graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //graph.DrawImage(m_Bottom,rect);
            //graph.FillRectangle(brush, m_LeftBottom.Width, this.Height - m_Bottom.Height, this.Width - m_RightBottom.Width - m_LeftBottom.Width, m_Bottom.Height);
            // graph.DrawImage(m_Bottom, m_LeftBottom.Width, this.Height - m_Bottom.Height, this.Width - m_RightBottom.Width - m_LeftBottom.Width, m_Bottom.Height);

            TextureBrush brush = new TextureBrush(m_Bottom);
            //平移（其实原来FillRectangle方法是实现被遮照的效果）
            brush.TranslateTransform(m_LeftBottom.Width, this.Height - m_Bottom.Height); 
            graph.FillRectangle(brush, m_LeftBottom.Width, this.Height - m_Bottom.Height, this.Width - m_RightBottom.Width - m_LeftBottom.Width, m_Bottom.Height);

        }

        /// <summary>
        /// 画右下角
        /// </summary>
        /// <param name="graph"></param>
        private void DrawRightBottom(Graphics graph)
        {
            //Brush brush = new TextureBrush(m_RightBottom, new Rectangle(0, 0, m_RightBottom.Width, m_RightBottom.Height));
            //graph.FillRectangle(brush, this.Width - m_RightBottom.Width, this.Height - m_RightBottom.Height, this.Width, this.Height);
            graph.DrawImage(m_RightBottom, this.Width - m_RightBottom.Width, this.Height - m_RightBottom.Height, m_LeftBottom.Width, m_LeftBottom.Height);
        }

        /// <summary>
        /// 画中间的部分
        /// </summary>
        /// <param name="graph"></param>
        private void DrawPanel(Graphics graph)
        {
            //graph.DrawRectangle(new Pen(SystemColors.Control), m_Left.Width, m_LeftTop.Height, this.Width - m_Left.Width - m_Right.Width , this.Height - m_LeftTop.Height - m_RightBottom.Height);
            graph.FillRectangle(SystemBrushes.Control, m_Left.Width, m_LeftTop.Height, this.Width - m_Left.Width - m_Right.Width , this.Height - m_LeftTop.Height - m_RightBottom.Height);
        }

        private void DrawStateBoxPosition()
        {
            pictureBoxClose.Left = this.Width - pictureBoxClose.Width - m_Right.Width;
            pictureBoxMax.Left = this.Width - m_Right.Width - pictureBoxClose.Width - pictureBoxMax.Width;
            pictureBoxMin.Left = this.Width -  m_Right.Width - pictureBoxClose.Width - pictureBoxMax.Width -pictureBoxMin.Width;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);            
            DrawTop(e.Graphics);
            DrawLeftTop(e.Graphics);
            DrawRightTop(e.Graphics);
            DrawLeft(e.Graphics);
            DrawRight(e.Graphics);
            DrawLeftBottom(e.Graphics);
            DrawBottom(e.Graphics);
            DrawRightBottom(e.Graphics);
            DrawPanel(e.Graphics);
            DrawStateBoxPosition();         
        }

        #endregion

        #region 鼠标变换
        /// <summary>
        /// 根据不同的鼠标位置来变换出不同的鼠标形状
        /// </summary>
        private void ChangeMouseCursor()
        {
            Point mousePos = PointToClient(MousePosition);
            //上
            if (mousePos.X > m_FormEdge && mousePos.X < this.Width - m_FormEdge - pictureBoxClose.Width - pictureBoxMin.Width - pictureBoxMax.Width && mousePos.Y <= m_FormEdge)
            {
                this.Cursor = Cursors.SizeNS;
            }
            //下
            else if (mousePos.X > m_FormEdge && mousePos.X < this.Width - m_FormEdge && mousePos.Y > this.Height - m_FormEdge)
            {
                this.Cursor = Cursors.SizeNS;
            }
            //左
            else if (mousePos.X <= m_FormEdge && mousePos.Y > m_FormEdge && mousePos.Y < this.Height - m_FormEdge)
            {
                this.Cursor = Cursors.SizeWE;
            }
            //右
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y > m_FormEdge && mousePos.Y < this.Height - m_FormEdge)
            {
                this.Cursor = Cursors.SizeWE;
            }
            //左上角
            else if (mousePos.X <= m_FormEdge && mousePos.Y <= m_FormEdge)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            //右上角
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y <= m_FormEdge)
            {
                this.Cursor = Cursors.SizeNESW;
            }
            //左下角
            else if (mousePos.X <= m_FormEdge && mousePos.Y >= this.Height - m_FormEdge)
            {
                this.Cursor = Cursors.SizeNESW;
            }
            //右下角
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y >= this.Height - m_FormEdge)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            //默认
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 界面大小调整
        /// <summary>
        /// 根据鼠标不同的位置进行大小调整
        /// </summary>
        private void ChangeFormSize()
        {
            //为什么要加入一个位置上面的判断呢，这是为了一个细节考虑的，如果不加判断，拖动起来就会感觉怪怪的，自己试一下。
            Point mousePos = PointToClient(MousePosition);
            //上
            if (mousePos.X > m_FormEdge && mousePos.X < this.Width - m_FormEdge && mousePos.Y <= m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.TOP;
            }
            //下
            else if (mousePos.X > m_FormEdge && mousePos.X < this.Width - m_FormEdge && mousePos.Y > this.Height - m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.BOTTOM;
            }
            //左
            else if (mousePos.X <= m_FormEdge && mousePos.Y > m_FormEdge && mousePos.Y < this.Height - m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.LEFT;
            }
            //右
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y > m_FormEdge && mousePos.Y < this.Height - m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.RIGHT;
            }
            //左上角
            else if (mousePos.X <= m_FormEdge && mousePos.Y <= m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.LEFTTOP;
            }
            //右上角
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y <= m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.RIGHTTOP;
            }
            //左下角
            else if (mousePos.X <= m_FormEdge && mousePos.Y >= this.Height - m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.LEFTBOTTOM;
            }
            //右下角
            else if (mousePos.X >= this.Width - m_FormEdge && mousePos.Y >= this.Height - m_FormEdge && b_IsMouseDown && m_MousePosition == VistaMousePosition.NORMAL)
            {
                m_MousePosition = VistaMousePosition.RIGHTBOTTOM;
            }
            //默认
            //else
            //{
            //    m_MousePosition = VistaMousePosition.NORMAL;
            //}
            if (b_IsMouseDown)
            {
                if (m_MousePosition != VistaMousePosition.NORMAL)
                {
                    
                    int right, bottom;
                    switch (m_MousePosition)
                    {
                        case VistaMousePosition.TOP:
                            bottom = this.Bottom;
                            this.Top = MousePosition.Y;
                            this.Height = bottom - this.Top;                  
                            break;
                        case VistaMousePosition.BOTTOM:
                            this.Height = MousePosition.Y - this.Top;
                            break;
                        case VistaMousePosition.LEFT:
                            right = this.Right;
                            this.Left = MousePosition.X;
                            this.Width = right - this.Left;
                            break;
                        case VistaMousePosition.RIGHT:
                            this.Width = Control.MousePosition.X - this.Left;
                            break;
                        case VistaMousePosition.LEFTTOP:
                            right = this.Right;
                            bottom = this.Bottom;
                            this.Top = MousePosition.Y;
                            this.Height = bottom - this.Top;
                            this.Left = MousePosition.X;
                            this.Width = right - this.Left;
                            break;
                        case VistaMousePosition.RIGHTTOP:
                            bottom = this.Bottom;
                            this.Top = MousePosition.Y;
                            this.Height = bottom - this.Top;
                            this.Width = Control.MousePosition.X - this.Left;
                            break;
                        case VistaMousePosition.LEFTBOTTOM:
                            right = this.Right;
                            this.Height = MousePosition.Y - this.Top;
                            this.Left = MousePosition.X;
                            this.Width = right - this.Left;
                            break;
                        case VistaMousePosition.RIGHTBOTTOM:
                            this.Height = MousePosition.Y - this.Top;
                            this.Width = Control.MousePosition.X - this.Left;
                            break;
                    }
                    Invalidate(false);
                    b_IsChangingSize = true;
                }
            }
        }

        /// <summary>
        /// 调整界面的最大化最小化
        /// </summary>
        private void ChangeFormStyle()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                pictureBoxMax.Image = Properties.Resources.Max;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                pictureBoxMax.Image = Properties.Resources.max3;
            }
            Invalidate(false);
        }
        #endregion

        private void VistaForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!b_IsChangingSize)
            {
                //设置大小的时候不允许拖动
                if (e.Button == MouseButtons.Left && e.Y > m_FormEdge && e.Y < m_Top.Height || b_IsMoveForm)
                {
                    Point mousePos = new Point();
                    mousePos = Control.MousePosition;
                    mousePos.Offset(m_MouseOffset.X, m_MouseOffset.Y);
                    Location = mousePos;
                    b_IsMoveForm = true;//正在拖动
                }
            }
            if (!b_IsMoveForm)
            {
                //正在拖动的时候不允许设置大小
                ChangeMouseCursor();
                ChangeFormSize();
            }
            //this.Refresh();//重新OnPaint
            //这个方法也可以重新OnPaint
            //Graphics f = this.CreateGraphics();
            //System.Drawing.Rectangle cliprect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            //this.OnPaint(new System.Windows.Forms.PaintEventArgs(f, cliprect));  
        }

        private void VistaForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseOffset = new Point(-e.X, -e.Y);
            b_IsMouseDown = true;
        }

        private void VistaForm_MouseUp(object sender, MouseEventArgs e)
        {
            b_IsChangingSize = false;
            b_IsMouseDown = false;
            b_IsMoveForm = false;
            m_MousePosition = VistaMousePosition.NORMAL;
        }

        private void VistaForm_Load(object sender, EventArgs e)
        {
            CommonClass.SetTaskMenu(this);
            //this.BackColor = m_BackGroundColor;
        }

        private void VistaForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mousePos = new Point();
            mousePos = PointToClient(MousePosition);
            if (mousePos.Y <= m_Top.Height)
            {
                ChangeFormStyle();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            Invalidate(false);
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMin.Image = Properties.Resources.Min1;
        }

        private void pictureBoxMin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMin.Image = Properties.Resources.Min;
        }

        private void pictureBoxMax_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pictureBoxMax.Image = Properties.Resources.Max1;
            }
            else
            {
                pictureBoxMax.Image = Properties.Resources.Max2;
            }
        }

        private void pictureBoxMax_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pictureBoxMax.Image = Properties.Resources.Max;
            }
            else
            {
                pictureBoxMax.Image = Properties.Resources.max3;
            }
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.Close1;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.Close;
        }
    }
}