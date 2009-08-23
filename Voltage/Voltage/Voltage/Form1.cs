using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class Form1 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public DataTable VoltageTable;
        //参数
        int XBase = 30;
        int YBase;
        int XCoordinateWidth = 600;
        int YCoordinateHight = 300;
        int XPointNum = 30;
        int YPointNum = 20;
        int ScaleHeight = 3;
        int YMax = 15;

        int VoltageTableCurrentIndex;
        int VoltageTableCurrentIndex_temp;
        int X_temp;

        public Graphics g_Data;

        //控件变量
        public bool LeftClick = false;
        public int MoveStartX;
        
        public Panel Panel_Data;
        public Form1()
        {
            InitializeComponent();
        }

        public void InitVoltageTable()
        {
            VoltageTable = new DataTable();
            VoltageTable.Columns.Add("CollectID");
            VoltageTable.Columns.Add("DataTime");
            VoltageTable.Columns.Add("DataValue");

            //填充测试数据,Sina函数
            for (int i = 0; i < 100; i++)
            {
                VoltageTable.Rows.Add(new object[]{"0000",System.DateTime.Now.ToLocalTime().ToString(),6*Math.Sin(3.14/20*i)+6});
            }                 
            

        }



        public void DrawVoltageData()
        {

        }

        public void GrawAll()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.YBase = this.Height - 60;
            this.VoltageTableCurrentIndex = 0;


            //this.Panel_Data = new Panel();
            //Panel_Data.Location = new Point(XBase, YBase - YCoordinateHight);
            //Panel_Data.Size = new Size(XCoordinateWidth, YCoordinateHight);
            //Panel_Data.BorderStyle = BorderStyle.None;
            //Panel_Data.Paint += new PaintEventHandler(Panel_Data_Paint);
            //this.Controls.Add(Panel_Data);

            this.InitVoltageTable();
        }



        public void DrawData(Graphics g)
        {
            //g.Clear(this.BackColor);
            if (VoltageTableCurrentIndex > VoltageTable.Rows.Count)
                return;
            Pen p_Data = new Pen(Color.Blue, 2);
            Pen p_Circle = new Pen(Color.Red, 2);
            
            int PointNum = (VoltageTableCurrentIndex + XPointNum) < VoltageTable.Rows.Count ? XPointNum : VoltageTable.Rows.Count - VoltageTableCurrentIndex;
            Point[] point = new Point[PointNum];
            for (int i = 0; i < PointNum; i++)
            {
                Double DataValue = Convert.ToDouble(VoltageTable.Rows[VoltageTableCurrentIndex + i]["DataValue"].ToString());
                int Y = (int)(YBase - DataValue / YMax * YCoordinateHight);
                point[i] = new Point(XBase + XCoordinateWidth / XPointNum * i, Y);

            }

            //g.DrawLine(p_Data, new Point(0, 0), new Point(100, 100));
            for (int i = 1; i < PointNum; i++)
            {
                g.DrawLine(p_Data, point[i - 1], point[i]);
                Rectangle rect=new Rectangle(point[i].X-2,point[i].Y-4,8,8);
                g.DrawEllipse(p_Circle,rect);
                g.FillEllipse(Brushes.Red, rect);

            }
            
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           // if (!this.LeftClick)
                this.DrawBase(e.Graphics);
            this.DrawData(e.Graphics);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MoveStartX = e.X;
                this.X_temp = e.X;
                this.VoltageTableCurrentIndex_temp = this.VoltageTableCurrentIndex;
                this.LeftClick = true;               
            }

            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.VoltageTableCurrentIndex = this.VoltageTableCurrentIndex_temp + (int)((Double)(e.X - this.MoveStartX) / XCoordinateWidth * XPointNum);
                this.LeftClick = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.LeftClick)
            {
                if (e.X - this.X_temp > 100 || e.X - this.X_temp < 100)
                {
                    X_temp = e.X;
                    int StepIndex = (int)((Double)(e.X - this.MoveStartX) / XCoordinateWidth * XPointNum);
                    if (VoltageTableCurrentIndex_temp + StepIndex >= 0)
                    {
                        this.VoltageTableCurrentIndex = VoltageTableCurrentIndex_temp + StepIndex;
                        this.Refresh();                      
                    }
                }
            }
        }
        public void DrawBase(Graphics g)
        {

            Pen p_fakeCoordinate = new Pen(Color.DarkGray, 1);
            Point XBasePoint = new Point(XBase, YBase);

            //画横坐标及纵坐标            
            Pen p_Coordinate = new Pen(Color.Black, 1);
            g.DrawLine(p_Coordinate, XBasePoint, new Point(XBase + XCoordinateWidth, YBase));
            g.DrawLine(p_Coordinate, XBasePoint, new Point(XBase, YBase - YCoordinateHight));

            //画辅助横纵坐标
            g.DrawLine(p_fakeCoordinate, new Point(XBase, YBase - YCoordinateHight), new Point(XBase + XCoordinateWidth, YBase - YCoordinateHight));
            g.DrawLine(p_fakeCoordinate, new Point(XBase + XCoordinateWidth, YBase), new Point(XBase + XCoordinateWidth, YBase - YCoordinateHight));

            //画横坐标及纵坐标刻度
            for (int i = 1; i <= XPointNum; i++)
            {
                Point StartPoint = new Point(XBase + XCoordinateWidth / XPointNum * i, YBase);
                Point EndPoint = new Point(XBase + XCoordinateWidth / XPointNum * i, YBase - ScaleHeight);
                g.DrawLine(p_Coordinate, StartPoint, EndPoint);
            }

            for (int i = 1; i <= YPointNum; i++)
            {
                Point StartPoint = new Point(XBase, YBase - YCoordinateHight / YPointNum * i);
                Point EndPoint = new Point(XBase + ScaleHeight, YBase - YCoordinateHight / YPointNum * i);
                g.DrawLine(p_Coordinate, StartPoint, EndPoint);
            }            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
