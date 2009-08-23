using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Voltage
{
    public partial class OneTimeZendChart : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public OneTimeZendChart()
        {
            InitializeComponent();

            //this.comboBox_Zoom.Items.AddRange(new object[] { "50%", "80%", "100%", "150%", "200%", "300%" });
            //this.comboBox_Zoom.SelectedIndex = 2;
        }
        public LineItemProperty[] propertys;
        public LineItem[] lineItem;

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphPane myPane = this.zedGraphControl1.GraphPane;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 1.5;
            // Set the titles
            myPane.Title.Text = "阴极电位保护系统";
            myPane.XAxis.Title.Text = "里程";
            myPane.YAxis.Title.Text = "电压";
            myPane.Title.FontSpec.GetFont(1111);
            myPane.XAxis.Title.FontSpec.Size = 12;
            myPane.YAxis.Title.FontSpec.Size = 12;

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.FromArgb(255, 255, 245), Color.FromArgb(255, 255, 190), 90F);
            // Fill the pane background with a gradient
            myPane.Fill = new Fill(Color.WhiteSmoke, Color.Lavender, 0F);
            // Draw a box item to highlight a value range
            BoxObj box = new BoxObj(0, 1.2, 1.4, 0.4, Color.Empty,
                    Color.FromArgb(150, Color.LightGreen));
            box.Fill = new Fill(Color.FromArgb(100, Color.FromArgb(88,88, 88)), Color.FromArgb(200, Color.FromArgb(88, 88, 88)), 45.0F);
            // Use the BehindAxis zorder to draw the highlight beneath the grid lines
            box.ZOrder = ZOrder.E_BehindCurves;
            // Make sure that the boxObj does not extend outside the chart rect if the chart is zoomed
            box.IsClippedToChartRect = true;
            // Use a hybrid coordinate system so the X axis always covers the full x range
            // from chart fraction 0.0 to 1.0
            box.Location.CoordinateFrame = CoordType.XChartFractionYScale;
            myPane.GraphObjList.Add(box);
           //GraphPane myPane=this.zedGraphControl1.GraphPane;
           //myPane.Title.Text = "阴极保护";
           //myPane.XAxis.Title.Text = "X轴";

           //LineItem item= myPane.AddCurve("line",null, new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, Color.Black,SymbolType.Circle);
           ////item.Line.Width = 1;
           ////item.Line.Fill = new Fill(Color.White, Color.Red, 45F);
           ////item.Symbol.Size = 20;
           ////item.Symbol.Fill = new Fill(Color.Red);
           //myPane.Chart.Fill = new Fill(Color.Blue);
                
           //this.zedGraphControl1.AxisChange();

           // Get a reference to the GraphPane
           //GraphPane myPane = this.zedGraphControl1.GraphPane;

           //// Set the titles
           //myPane.Title.Text = "My Test Date Graph";
           //myPane.XAxis.Title.Text = "Date";
           //myPane.XAxis.Title.Text = "My Y Axis";
           
           //// Make up some random data points
           //double x, y;
           //PointPairList list = new PointPairList();
           //for (int i = 0; i < 360; i++)
           //{
           //    x = (double)new XDate(1995, 5,5,1,1, i + 11);
           //    y = Math.Sin((double)i * Math.PI / 15.0+1.5);
           //    list.Add(x, y);
           //}

           //// Generate a red curve with diamond
           //// symbols, and "My Curve" in the legend
           //CurveItem myCurve = myPane.AddCurve("My Curve",
           //      list, Color.Red, SymbolType.Diamond);
           
           //// Set the XAxis to date type
           //myPane.XAxis.Type = AxisType.Date;

           //// Tell ZedGraph to refigure the axes since the data 
           //// have changed
           //this.zedGraphControl1.AxisChange();

        }


        public DataRow getDataRowByCollectId(string CollectId,DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["CollectId"].ToString() == CollectId)
                    return row;
            }
            return null;
        }
        public DataTable getLineDataTable(ArrayList CollectIdList)
        {
            string idList = "";
            foreach (string id in CollectIdList)
            {
                idList += "'"+id + "',";
            }
            idList = idList.Substring(0, idList.Length - 1);
            DataSet ds= OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from CollectInfo where CollectId in (" + idList + ")");
            return ds.Tables[0];
        }
        public void ShowChartingForOneTime(DataSet ds)
        {
            // Get a reference to the GraphPane
            GraphPane myPane = this.zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            // Set the titles

            myPane.Legend.IsVisible = false;

            //ArrayList CollectIdList = this.getCollectIdList(ds);
            //this.comboBox_CollectId.Items.Clear();
            //propertys = new LineItemProperty[CollectIdList.Count];
            //lineItem = new LineItem[CollectIdList.Count];
            LineItem lineItem;
            int i = 0;
            //foreach (string CollectId in CollectIdList)
            //{
                //this.comboBox_CollectId.Items.Add(CollectId);
                PointPairList list = new PointPairList();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //if (CollectId == row["CollectId"].ToString())
                    //{
                    // list.Add((double)new XDate(Convert.ToDouble(row["CollectId"].ToString())), Convert.ToDouble(row["DataValue"].ToString()));
                    if (row["Mileage"].ToString().Trim() == "")
                        list.Add(0, Convert.ToDouble(row["DataValue"].ToString()));
                    else
                        list.Add(Convert.ToDouble(row["Mileage"].ToString()), Convert.ToDouble(row["DataValue"].ToString()));

                    //}
                }
                lineItem = myPane.AddCurve("单时间点电位", list, Color.Red, SymbolType.Circle);
                lineItem.Line.IsAntiAlias = true;
                lineItem.Symbol.Border.Color = lineItem.Line.Color;
                lineItem.Symbol.Fill = new Fill(lineItem.Line.Color);
                lineItem.Symbol.Size = 4.0F;

                //设置属性电位
                //propertys[i] = new LineItemProperty();
                //propertys[i].collectId = CollectId;
                //propertys[i].isVisable = true;
                i++;

            //}
            //if (this.comboBox_CollectId.Items.Count > 0)
            //    this.comboBox_CollectId.SelectedIndex = 0;

            //for (int i = 0; i < 360; i++)
            //{
            //    x = (double)new XDate(1995, 5, 5, 1, 1, i + 11);
            //    y = Math.Sin((double)i * Math.PI / 15.0 + 1.5);
            //    list.Add(x, y);
            //}

            //// Generate a red curve with diamond
            //// symbols, and "My Curve" in the legend
            //CurveItem myCurve = myPane.AddCurve("My Curve",
            //      list, Color.Red, SymbolType.Diamond);

            // Set the XAxis to date type
            //myPane.XAxis.Type = AxisType.Date;

            // Tell ZedGraph to refigure the axes since the data 
            // have changed
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Invalidate();
        }

        public ArrayList getCollectIdList(DataSet ds)
        {
            ArrayList CollectIdList = new ArrayList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (CollectIdList.IndexOf(row["CollectId"].ToString()) == -1)
                    CollectIdList.Add(row["CollectId"].ToString());
            }
            return CollectIdList;
        }



        public LineItemProperty getPropertyByCollectId(string collectId)
        {
            foreach (LineItemProperty property in this.propertys)
            {
                if (property.collectId == collectId)
                {
                    return property;
                }
            }
            return null;
        }




        private void button3_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPageSetup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPrintPreview();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPrint();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.Copy(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.SaveAsBitmap();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOut(this.zedGraphControl1.GraphPane);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOutAll(this.zedGraphControl1.GraphPane);
        }

        private void comboBox_Zoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PointF p = new PointF(0, 0);
            //this.zedGraphControl1.ZoomPane(this.zedGraphControl1.GraphPane, Convert.ToDouble(this.comboBox_Zoom.Text.Trim('%'))/100, p, false);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.Copy(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.SaveAsBitmap();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOut(this.zedGraphControl1.GraphPane);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOutAll(this.zedGraphControl1.GraphPane);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPageSetup();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPrintPreview();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.DoPrint();
        }

    }



}
