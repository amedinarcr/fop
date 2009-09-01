using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace Voltage
{
    class Lib
    {
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        //加载Excel 
        public static DataSet LoadDataFromExcel(string filePath) 
        { 
            try 
            { 
                string strConn; 
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'"; 
                OleDbConnection OleConn = new OleDbConnection(strConn); 
                OleConn.Open(); 
                String sql = "SELECT * FROM  [Sheet1$]";//可是更改Sheet名称，比如sheet2，等等 

                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn); 
                DataSet OleDsExcle = new DataSet(); 
                OleDaExcel.Fill(OleDsExcle, "Sheet1"); 
                OleConn.Close(); 
                return OleDsExcle; 
            } 
            catch (Exception err) 
            { 
               
                MessageBox.Show("数据绑定Excel失败!失败原因：" + err.Message, "提示信息", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return null; 
            } 
        }


        public static bool SaveDataTableToExcel(System.Data.DataTable excelTable, string filePath) 
        { 
            Microsoft.Office.Interop.Excel.Application app = 
                new Microsoft.Office.Interop.Excel.ApplicationClass(); 
            try 
            { 
                app.Visible = false; 
                Workbook wBook = app.Workbooks.Add(true); 
                Worksheet wSheet = wBook.Worksheets[1] as Worksheet; 
                if (excelTable.Rows.Count > 0) 
                { 
                    int row = 0; 
                    row = excelTable.Rows.Count; 
                    int col = excelTable.Columns.Count; 
                    for (int i = 0; i < row; i++) 
                    { 
                        for (int j = 0; j < col; j++) 
                        { 
                            string str = excelTable.Rows[i][j].ToString(); 
                            wSheet.Cells[i + 2, j + 1] = str; 
                        } 
                    } 
                } 

                int size = excelTable.Columns.Count; 
                for (int i = 0; i < size; i++) 
                { 
                    wSheet.Cells[1, 1 + i] = excelTable.Columns[i].ColumnName; 
                } 
                //设置禁止弹出保存和覆盖的询问提示框 
                app.DisplayAlerts = false; 
                app.AlertBeforeOverwriting = false; 
                //保存工作簿 
                wBook.Save(); 
                //保存excel文件 
                app.Save(filePath); 
                app.SaveWorkspace(filePath); 
                app.Quit(); 
                app = null; 
                return true; 
            } 
            catch (Exception err) 
            { 
                MessageBox.Show("导出Excel出错！错误原因：" + err.Message, "提示信息", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return false; 
            } 
            finally 
            { 
            } 
        }

        public static void UpdateApplicationSetting(string appSettingName, string appSettingValue)
        {
            string configFileName = System.Windows.Forms.Application.ExecutablePath + ".config";
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(configFileName);
            string configString = @"configuration/applicationSettings/Voltage.Properties.Settings/setting[@name='" + appSettingName + "']/value";
            System.Xml.XmlNode configNode = doc.SelectSingleNode(configString);
            if (configNode != null)
            {
                configNode.InnerText = appSettingValue;
                doc.Save(configFileName);
                // 刷新应用程序设置
                Properties.Settings.Default.Reload();
            }
        }

        public static System.Drawing.Color GetRandomColor()
        {
            Random RandomNum_First = new Random((int)DateTime.Now.Ticks);
            //  对于C#的随机数，没什么好说的 
            System.Threading.Thread.Sleep(RandomNum_First.Next(50));
            Random RandomNum_Sencond = new Random((int)DateTime.Now.Ticks);

            //  为了在白色背景上显示，尽量生成深色 
            int int_Red = 100+RandomNum_First.Next(156);
            int int_Green = RandomNum_Sencond.Next(256);
            int int_Blue = (int_Red + int_Green > 400) ? 0 : 400 - int_Red - int_Green;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;

            return System.Drawing.Color.FromArgb(250,int_Red, int_Green, int_Blue);
        }

        public static string GetNewFileName()
        {
            string dir = Voltage.Properties.Settings.Default.OutPutDataDir;
            return dir + System.DateTime.Now.ToString(Voltage.Properties.Settings.Default.PipelineName.Trim() + "_" + Voltage.Properties.Settings.Default.ProtectStationName.Trim() + "_yyyyMMddHHmmss");
        }

        public static string parseLatitude(string latitude)
        {
            try
            {
                int index1 = latitude.IndexOf(',');
                string a = latitude.Substring(0, index1);
                int index2 = latitude.IndexOf(',', index1 + 1);
                string b = latitude.Substring(index1 + 1, index2 - index1 - 1);
                string c = latitude.Substring(index2 + 1);
                if (a == "" && b == "" && c == "")
                    return "";
                return a + "°" + b + "'" + c + "''";
            }catch(Exception ex)
            {
                return "";
            }
        }

        public static int InsertDefaultCollectInfo(String CollectId)
        {
            string insertSql = "insert into CollectInfo(CollectId,ProtectStationName,TestPileID,PipelineName,Mileage,Latitude,Remark,LineWidth,LineStyle,LineColor,SymbolType) values(@CollectId,@ProtectStationName,@TestPileID,@PipelineName,@Mileage,@Latitude,@Remark,@LineWidth,@LineStyle,@LineColor,@SymbolType)";
            OleDbParameter p_CollectId = new OleDbParameter("CollectId", CollectId);
            OleDbParameter p_ProtectStationName = new OleDbParameter("@ProtectStationName", "");
            OleDbParameter p_TestPileID = new OleDbParameter("@TestPileID", "");
            OleDbParameter p_PipelineName = new OleDbParameter("PipelineName", Voltage.Properties.Settings.Default.PipelineName);
            OleDbParameter p_Mileage = new OleDbParameter("@Mileage", "");
            OleDbParameter p_Latitude = new OleDbParameter("@Latitude", ",,&,,");
            OleDbParameter p_Remark = new OleDbParameter("@Remark", "");
            OleDbParameter p_LineWidth = new OleDbParameter("@LineWidth", "1");
            p_LineWidth.OleDbType = OleDbType.Integer;
            OleDbParameter p_LineStyle = new OleDbParameter("@LineStyle", "0");
            p_LineStyle.OleDbType = OleDbType.Integer;
            OleDbParameter p_LineColor = new OleDbParameter("@LineColor", Lib.GetRandomColor().ToArgb().ToString());
            p_LineColor.OleDbType = OleDbType.Integer;
            OleDbParameter p_SymbolType = new OleDbParameter("@SymbolType", "0");
            p_SymbolType.OleDbType = OleDbType.Integer;
            OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql, new OleDbParameter[] { p_CollectId, p_ProtectStationName, p_TestPileID, p_PipelineName, p_Mileage, p_Latitude, p_Remark, p_LineWidth, p_LineStyle, p_LineColor, p_SymbolType });
            return Convert.ToInt32(OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, "select top 1 ID from CollectInfo order by ID desc"));

        }





    }


}
