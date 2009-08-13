using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using System.Windows.Forms;
using System.IO;

namespace Voltage
{
    class VoltageData
    {
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="DataType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public static void OutPut(string fileName,int DataType, DateTime startTime, DateTime endTime)
        {
            try
            {
                switch (DataType)
                {
                    case 0:
                        DataSet ds = new DataSet();
                        DataTable dt1 = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from DataTable where DataTime>=#" + startTime + "# and DataTime<=#" + endTime + "#").Tables[0].Copy();
                        dt1.TableName = "DataTable";
                        DataTable dt2 = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select * from CollectInfo").Tables[0].Copy();
                        dt2.TableName = "CollectInfo";
                        ds.Tables.Add(dt1);
                        ds.Tables.Add(dt2);
                        ds.WriteXml(fileName);
                        break;
                    case 1:
                        ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectInfo.PipelineName,'',CollectInfo.TestPileID,DataValue,DataTime,CollectInfo.AdminName from DataTable left join CollectInfo on DataTable.CollectId=Collectinfo.CollectId  where DataTime>=#" + startTime + "# and DataTime<=#" + endTime + "#");

                        Excel.ExcelEdit excel = new Excel.ExcelEdit();
                       
                        excel.Open(Application.StartupPath + "\\Model.xls");
                        excel.AddTable(ds.Tables[0], "Sheet1", 13, 1);
                        if (File.Exists(fileName))
                            File.Delete(fileName);
                        if (excel.SaveAs(fileName) == false)
                        {
                            MessageBox.Show("保存失败");
                        }
                        excel.Close();
                        break;
                }
                Lib.UpdateApplicationSetting("LastOutputTime", endTime.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败!\n失败原因:\n\t" + ex.Message);
            }
        }

        public static void OutPutTimer(string SavePath)
        {
            DateTime now = DateTime.Now;
            string fileName = SavePath + now.AddMonths(-1).ToString("yyyyMM") + ".xml";
            DateTime startTime = new DateTime(now.Year, now.Month - 1, 1, 0, 0, 0);
            DateTime endTime = startTime.AddMonths(1);
            if (!File.Exists(fileName))
                VoltageData.OutPut(fileName, 0, startTime, endTime);
                
            fileName = SavePath + now.AddMonths(-1).ToString("yyyyMM") + ".xls";
            if(!File.Exists(fileName))

                VoltageData.OutPut(fileName, 1, startTime, endTime);
        }
    }
}
