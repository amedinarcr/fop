using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Voltage
{
    public partial class DataCharting : UserControl
    {
        public DataSet ds;
        public DataCharting()
        {
            InitializeComponent();
        }

        private void DataCharting_Load(object sender, EventArgs e)
        {

        }
        public void ShowCharting2(DataSet ds)
        {
            this.ds = ds;
            chart1.Type = ChartType.Combo;

            //init Series
            Series series = new Series();
            series.Type = SeriesType.Line;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Element elem = new Element();
                //elem.XValue = Convert.ToInt16(row["CollectId"].ToString());
                elem.YValue = Convert.ToDouble(row["DataValue"].ToString());
                series.AddElements(elem);
            }
            this.chart1.SeriesCollection.Add(series);            
        }
        public void ShowCharting(DataSet ds)
        {
            this.ds = ds;
            chart1.Type = ChartType.Combo;
            
            //init Series
            ArrayList CollectIdList = this.getCollectIdList();
            foreach (string CollectId in CollectIdList)
            {
                Series series = new Series(CollectId);
                series.Type = SeriesType.Line;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (CollectId == row["CollectId"].ToString())
                    {
                        Element elem = new Element();
                        //elem.XDateTime = Convert.ToDateTime(row["DataTime"].ToString());                      
                        elem.YValue = Convert.ToDouble(row["DataValue"].ToString());
                        series.AddElements(elem);
                    }
                }

                this.chart1.SeriesCollection.Add(series);
            }
        }
        public ArrayList getCollectIdList()
        {
            ArrayList CollectIdList = new ArrayList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (CollectIdList.IndexOf(row["CollectId"].ToString()) == -1)
                    CollectIdList.Add(row["CollectId"].ToString());
            }
            return CollectIdList;
        }

        private void chart1_Load(object sender, EventArgs e)
        {

        }
    }
}
