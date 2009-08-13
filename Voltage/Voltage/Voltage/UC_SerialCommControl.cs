using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;

namespace Voltage
{
    public partial class UC_SerialCommControl : UserControl
    {
        public PortData portData;
        public UC_SerialCommControl()
        {
            InitializeComponent();
            UserControl.CheckForIllegalCrossThreadCalls = false;
           
        }
      
        private void UserControl_SerialCommControl_Load(object sender, EventArgs e)
        {
            //init Serial Commbox
            foreach (string portName in SerialPort.GetPortNames())
            {
                this.comboBox_Serial.Items.Add(portName);
            }
            if (this.comboBox_Serial.Items.Count > 0)
                this.comboBox_Serial.SelectedIndex = 0; 

            //init date setting control
            //this.comboBox_SetdateType.SelectedIndex = 0;
        }

        private void button_OpenSerial_Click(object sender, EventArgs e)
        {
            if (this.button_OpenSerial.Text == "打开串口")
            {
                portData = new PortData(this.comboBox_Serial.Text, 9600, Parity.None);
                portData.Received += new PortDataReceivedEventHandle(portData_Received);
                portData.Open();
                this.comboBox_Serial.Enabled = false;
                this.button_OpenSerial.Text = "关闭串口";
            }
            else
            {
                this.portData.Close();
                this.comboBox_Serial.Enabled = true;
                this.button_OpenSerial.Text = "打开串口";
            }
        }
        public StringBuilder SerialString=new StringBuilder();
        void portData_Received(object sender, PortDataReciveEventArgs e)
        {
            
            string HexStr = Lib.byteToHexStr(e.Data);
            this.SerialString.Append(HexStr);
           
            //ShowDegete show = new ShowDegete(this.ShowResult);
            //Invoke(show, new object[]{HexStr});
            //show(HexStr);
            //MessageBox.Show(HexStr);
        }
        public delegate void ShowDegete(string str);
        public void ShowResult(string str)
        {
            //this.textBox1.AppendText(str);
        }
        private void comboBox_SetdateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (this.comboBox_SetdateType.SelectedIndex)
            //{
            //    case 0:
            //        this.numericUpDown_date.Minimum = 0;
            //        this.numericUpDown_date.Maximum = 99;
            //        break;
            //    case 1:
            //        this.numericUpDown_date.Minimum = 1;
            //        this.numericUpDown_date.Maximum = 12;
            //        break;
            //    case 2:
            //        this.numericUpDown_date.Minimum = 1;
            //        this.numericUpDown_date.Maximum = 31;
            //        break;
            //    case 3:
            //        this.numericUpDown_date.Minimum = 1;
            //        this.numericUpDown_date.Maximum = 24;
            //        break;
            //    default:
            //        this.numericUpDown_date.Minimum = 1;
            //        this.numericUpDown_date.Maximum = 60;
            //        break;                    
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMachineTime set = new SetMachineTime(this.portData);
            set.ShowDialog();
            //if (portData == null)
            //{
            //    MessageBox.Show("还没有打开串口,请先打开串口!");
            //    return;
            //}
            //try
            //{
            //    decimal data = this.numericUpDown_date.Value;
            //    string DataStr = data.ToString();
            //    if (data.ToString().Length == 1)
            //        DataStr = "0" + data.ToString();
            //    string command = "F" + this.comboBox_SetdateType.SelectedIndex.ToString() + DataStr.ToString() + "00";
            //    byte[] receiveData=new byte[2];
            //    portData.SendCommand(command,ref receiveData,1000);
            //    string receiveString=Lib.byteToHexStr(receiveData);
            //    if (receiveString == command.Substring(0, 4))
            //        MessageBox.Show("设置成功");
            //    else
            //        MessageBox.Show("设置失败，串口未返回正确数据，请连接正确的下位机！");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("设置失败" + Environment.NewLine + "错误信息:" + ex.Message);
            //}
        }

        public void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("还未完成");
            //return;
            try
            {
                string command = "FA0000";
                if (portData == null)
                {
                    MessageBox.Show("还没有打开串口,请先打开串口!");
                    return;
                }
                portData.SendCommand(command);
                //System.Threading.Thread.Sleep(10000);
                this.SerialString = new StringBuilder();
                getCollectorData get = new getCollectorData(this.SerialString);
                if (get.ShowDialog() == DialogResult.Cancel)
                    portData.port.DiscardInBuffer();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("获取数据失败" + Environment.NewLine + "错误信息:" + ex.Message);
            }
        }

        public void button_inputData_Click(object sender, EventArgs e)
        {
            //DateTime time = new DateTime(2008, 12, 20, 8, 0, 0);
            //Random random = new Random();
            //for (int j = 0; j < 20; j++)
            //{
            //    time = new DateTime(2008, 12, 20, 8, 0, 0);
            //    for (int i = 0; i < 30; i++)
            //    {
            //        OleDbParameter p_CollectId = new OleDbParameter("@CollectId", "00" + j.ToString().PadLeft(2, '0'));
            //        time = time.AddSeconds(1);
            //        OleDbParameter p_DataTime = new OleDbParameter("@DataTime", time.ToString());
            //        p_DataTime.OleDbType = OleDbType.DBTimeStamp;
            //        OleDbParameter p_DataValue = new OleDbParameter("@DataValue", random.NextDouble());
            //        OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, "insert into DataTable(CollectId,DataTime,DataValue) values(@CollectId,@DataTime,@DataValue)", new OleDbParameter[] { p_CollectId, p_DataTime, p_DataValue });
            //    }
            //}
            //MessageBox.Show("导入成功");
            //return;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(this.openFileDialog1.FileName);
                    int insertCount = 0;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string CollectId = row["CollectId"].ToString();
                        DateTime dataTime = Convert.ToDateTime(row["DataTime"].ToString());
                        string querySql = "Select DataId from DataTable where CollectId='" + CollectId + "' and DataTime=#" + dataTime.ToString() + "#";
                        if (OleHelper.ExecuteScalar(OleHelper.Conn, CommandType.Text, querySql) == null)
                        {
                            string insertSql = "insert into DataTable(CollectId,DataTime,DataValue) values('" + CollectId + "',#" + row["DataTime"].ToString() + "#," + row["DataValue"].ToString() + ")";
                            OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql);
                            insertCount++;
                        }
                    }
                    MessageBox.Show("插入" + insertCount.ToString() + "条数据");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导入数据失败" + Environment.NewLine + "错误信息:" + ex.Message);
                }
            }

        }

        public void button_outputData_Click(object sender, EventArgs e)
        {
            ChoseOupputDataType OutPut = new ChoseOupputDataType();  
            OutPut.ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要清除数据?", "你确定要清除数据?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string command = "FB0000";
                    portData.SendCommand(command);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("清空数据失败" + Environment.NewLine + "错误信息:" + ex.Message);
                }
            }
        }
       
    }
}
