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
    public partial class ZendChart : Form
    {
        public ZendChart()
        {
            InitializeComponent();
            //this.comboBox_Zoom.Items.AddRange(new object[] { "50%", "80%", "100%", "150%", "200%", "300%" });
            //this.comboBox_Zoom.SelectedIndex = 2;
        }
        public LineItemProperty[] propertys;
        public LineItem[] lineItem;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Enabled = false;
            GraphPane myPane = this.zedGraphControl1.GraphPane;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 1.5;
            // Set the titles
            myPane.Title.Text = "阴极电位采集系统";
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;
            myPane.XAxis.Title.FontSpec.Size = 12;
            myPane.YAxis.Title.FontSpec.Size = 9;

            myPane.Title.FontSpec.IsDropShadow = true;
            myPane.Title.FontSpec.DropShadowColor = Color.FromArgb(50, 0, 0, 0);
            myPane.Title.FontSpec.DropShadowOffset = 0.2f;
            myPane.XAxis.Title.Text = "采集时间";
            myPane.XAxis.Title.FontSpec.IsDropShadow = true;
            myPane.XAxis.Title.FontSpec.DropShadowColor = Color.FromArgb(50, 0, 0, 0);
            myPane.XAxis.Title.FontSpec.DropShadowOffset = 0.2f;
            myPane.YAxis.Title.Text = "采集电压";
            myPane.YAxis.Title.FontSpec.IsDropShadow = true;
            myPane.YAxis.Title.FontSpec.DropShadowColor = Color.FromArgb(50, 0, 0, 0);
            myPane.YAxis.Title.FontSpec.DropShadowOffset = 0.2f;



            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.FromArgb(255, 255, 245), Color.FromArgb(255, 255, 190), 90F);
            // Fill the pane background with a gradient
            myPane.Fill = new Fill(Color.WhiteSmoke, Color.Lavender, 0F);
            // Draw a box item to highlight a value range
            BoxObj box = new BoxObj(0, 1.2, 1.4, 0.4, Color.Empty,
                    Color.FromArgb(150, Color.LightGreen));
            box.Fill = new Fill(Color.FromArgb(100, Color.FromArgb(88, 88, 88)), Color.FromArgb(200, Color.FromArgb(88, 88, 88)), 45.0F);
            // Use the BehindAxis zorder to draw the highlight beneath the grid lines
            box.ZOrder = ZOrder.E_BehindCurves;
            // Make sure that the boxObj does not extend outside the chart rect if the chart is zoomed
            box.IsClippedToChartRect = true;
            // Use a hybrid coordinate system so the X axis always covers the full x range
            // from chart fraction 0.0 to 1.0
            box.Location.CoordinateFrame = CoordType.XChartFractionYScale;
            myPane.GraphObjList.Add(box);
            

        }

        public void ShowCharting(DataSet ds)
        {
            // Get a reference to the GraphPane
            GraphPane myPane = this.zedGraphControl1.GraphPane;

            
   
            myPane.CurveList.Clear();
                       
            ArrayList CollectIdList = this.getCollectIdList(ds);
            this.comboBox_CollectId.Items.Clear();
            propertys = new LineItemProperty[CollectIdList.Count];
            lineItem = new LineItem[CollectIdList.Count];
            int i = 0;
            DataTable LineInfoTable = this.getLineDataTable(CollectIdList);
            foreach (string CollectId in CollectIdList)
            {
                this.comboBox_CollectId.Items.Add(CollectId);
                PointPairList list = new PointPairList();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (CollectId == row["CollectId"].ToString())
                    {
                        list.Add((double)new XDate(Convert.ToDateTime(row["DataTime"].ToString())), Convert.ToDouble(row["DataValue"].ToString()));
                    }
                }
                
               
                lineItem[i] = myPane.AddCurve(CollectId, list, Color.Red, SymbolType.Circle);
                lineItem[i].Line.IsAntiAlias = true;
                DataRow lineInfoRow = this.getDataRowByCollectId(CollectId, LineInfoTable);
                if (lineInfoRow != null)
                {
                    lineItem[i].Line.Width = Convert.ToInt32(lineInfoRow["LineWidth"].ToString());
                    lineItem[i].Line.Style = (DashStyle)Enum.Parse(typeof(DashStyle), lineInfoRow["LineStyle"].ToString());
                    lineItem[i].Line.Color = Color.FromArgb(Convert.ToInt32(lineInfoRow["LineColor"].ToString()));
                    lineItem[i].Symbol.Type = (SymbolType)Enum.Parse(typeof(SymbolType), lineInfoRow["SymbolType"].ToString());
                    lineItem[i].Symbol.Border.Color = lineItem[i].Line.Color;
                    lineItem[i].Symbol.Fill = new Fill(lineItem[i].Line.Color);
                    lineItem[i].Symbol.Size = 4.0F;

                }
                else
                {
                    lineItem[i].Line.Color = Lib.GetRandomColor();
                    lineItem[i].Symbol.Border.Color = lineItem[i].Line.Color;
                    lineItem[i].Symbol.Fill = new Fill(lineItem[i].Line.Color);
                    lineItem[i].Symbol.Size = 4.0F;
                }

               
                //设置属性
                propertys[i] = new LineItemProperty();
                propertys[i].collectId = CollectId;
                propertys[i].isVisable = true;
                i++;

            }
            if (this.comboBox_CollectId.Items.Count > 0)
                this.comboBox_CollectId.SelectedIndex = 0;
 
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
            myPane.XAxis.Type = AxisType.Date;

            // Tell ZedGraph to refigure the axes since the data 
            // have changed
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Invalidate();

            this.splitContainer2.Panel2.Enabled = true;
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

            // Set the titles
            myPane.Title.Text = "阴极电位采集系统";
            //myPane.XAxis.Title.Text = "采集时间";
            //myPane.YAxis.Title.Text = "采集电压";


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
                        list.Add((double)new XDate(Convert.ToDouble(row["CollectId"].ToString())), Convert.ToDouble(row["DataValue"].ToString()));
                    //}
                }
                lineItem = myPane.AddCurve("OneTime", list, Color.Red, SymbolType.Diamond);
                lineItem.Line.IsAntiAlias = true;


                //设置属性
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

        private void comboBox_CollectId_SelectedIndexChanged(object sender, EventArgs e)
        {

            LineItemProperty property = this.getPropertyByCollectId(this.comboBox_CollectId.Text);
            if (property.isVisable == true)
            {
                this.button_ShowHidden.Text = "隐藏";
            }
            else
                this.button_ShowHidden.Text = "显示";
                
            
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

        private void button_ShowHidden_Click(object sender, EventArgs e)
        {
            LineItemProperty property = propertys[this.comboBox_CollectId.SelectedIndex];
            if (property.isVisable == true)
            {
                this.button_ShowHidden.Text = "显示";
                property.isVisable = false;
                lineItem[this.comboBox_CollectId.SelectedIndex].IsVisible = false;
            }
            else
            {
                this.button_ShowHidden.Text = "隐藏";
                property.isVisable = true;
                lineItem[this.comboBox_CollectId.SelectedIndex].IsVisible = true;
            }
            //this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCollectProperty set = new SetCollectProperty(this.lineItem[this.comboBox_CollectId.SelectedIndex],this.comboBox_CollectId.Text);
            if (set.ShowDialog() == DialogResult.OK)
            {
                this.zedGraphControl1.Invalidate();
            }
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

        private void button9_Click(object sender, EventArgs e)
        {
            ViewCollectInfo view = new ViewCollectInfo(this.comboBox_CollectId.Text);
            view.ShowDialog();
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOut(this.zedGraphControl1.GraphPane);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.ZoomOutAll(this.zedGraphControl1.GraphPane);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.Copy(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.SaveAsBitmap();
        }

        private void uC_DataGridSearchQuery1_Load(object sender, EventArgs e)
        {

        }



    }


    public class LineItemProperty
    {
        public LineItemProperty() { }
        public string collectId;
        public bool isVisable;
        public int width;
        public Color color;
                
    }
}
