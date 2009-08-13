using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;

namespace Voltage
{
    public partial class UC_zendChart : UserControl
    {
        public UC_zendChart()
        {
            InitializeComponent();

            this.comboBox_Zoom.Items.AddRange(new object[] { "50%", "80%", "100%", "150%", "200%", "300%" });
            this.comboBox_Zoom.SelectedIndex = 2;
        }
        public LineItemProperty[] propertys;
        public LineItem[] lineItem;

        private void Form2_Load(object sender, EventArgs e)
        {
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

        public void ShowCharting(DataSet ds)
        {
            // Get a reference to the GraphPane
            GraphPane myPane = this.zedGraphControl1.GraphPane;

            // Set the titles
            myPane.Title.Text = "阴极点位采集系统";
            myPane.XAxis.Title.Text = "采集时间";
            myPane.YAxis.Title.Text = "采集电压";       
            
                       
            ArrayList CollectIdList = this.getCollectIdList(ds);
            this.comboBox_CollectId.Items.Clear();
            propertys = new LineItemProperty[CollectIdList.Count];
            lineItem = new LineItem[CollectIdList.Count];
            int i = 0;
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
                lineItem[i] = myPane.AddCurve(CollectId, list, Color.Red, SymbolType.Diamond);
                lineItem[i].Line.IsAntiAlias = true;

               
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
            this.zedGraphControl1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCollectProperty set = new SetCollectProperty(this.lineItem[this.comboBox_CollectId.SelectedIndex],this.comboBox_CollectId.Text);
            set.ShowDialog();
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
