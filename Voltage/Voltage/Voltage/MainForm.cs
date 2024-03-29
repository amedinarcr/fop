﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ComponentFactory.Krypton.Toolkit;

namespace Voltage
{
    public partial class MainForm : KryptonForm
    {
        public PortData portData;
        public  string AppName="阴极保护电位自动采集系统";
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        public UC_DataGridCharting MainControl;
        public MainForm()
        {
            //this.components = new System.ComponentModel.Container();
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void userControl_SerialCommControl1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new KryptonManager(this.components);
            //DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "select CollectId,DataTime,DataValue from DataTable where CollectId in ('0001','0002') and DataTime>=#2008-12-20 8:00:01# and DataTime<#2008-12-20 8:00:20#");
            Program.mainForm.ShowCharting(3, null);
            //this.LoadSerialMenuItem(); //开启手动打开串口服务
            this.StartSerialService();  //打开检测串口服务
            this.StartOutPutTimerService();//打开定时导出服务
        }


        
        public void StartSerialService()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        public void StartOutPutTimerService()
        {
                 
            Timer t_OutPutData = new Timer();
            t_OutPutData.Interval = 1000 * 60 * 60; //1小时检测一次
            t_OutPutData.Tick += new EventHandler(t_OutPutData_Tick);
            t_OutPutData.Start();
        }

        void t_OutPutData_Tick(object sender, EventArgs e)
        {
            if (Voltage.Properties.Settings.Default.IsOpenOutPutTimer)
            {
                int CurrentDay = DateTime.Now.Day;
                if (CurrentDay == Voltage.Properties.Settings.Default.OutPutDay)
                    VoltageData.OutPutTimer(Voltage.Properties.Settings.Default.OutPutDataDir);
            }
            else
            {
                Timer t = sender as Timer;
                t.Stop();
            }
        }
        void t_Tick(object sender, EventArgs e)
        {
            if (this.OpenSerial())
            {
                
                if (!this.IsOld)
                {
                    this.SerialString = new StringBuilder();
                    portData.ReceiveEventFlag = false;
                    this.portData.Received += new PortDataReceivedEventHandle(this.portData_Received);
                    this.Text = this.AppName + "(已联机)";
                }
            }
            else
            {
                
                this.Text = this.AppName + "(未联机)";
            }
        }
        public int PortCount = 0;
        public bool IsOld = false;
        public ArrayList BadPortList = new ArrayList();
        public bool OpenSerial()
        {

            try
            {

                
                //this.SerialInfo.Text = SerialPort.GetPortNames().Length.ToString();
                //if (PortCount == SerialPort.GetPortNames().Length)
                //{
                //    this.IsOld = true;
                //    return true;
                //}
                //else
                //{
                //    this.IsOld = false;
                //    PortCount = SerialPort.GetPortNames().Length;
                //}
                foreach (string portName in SerialPort.GetPortNames())
                {
                    if (this.portData != null && this.portData.port.PortName == portName)
                    {

                        if (this.portData.port.IsOpen)
                        {
                            this.IsOld = true;
                            return true;
                        }
                        else
                        {

                            this.portData = null;
                            //return true;
                        }
                    }
                }
                foreach (string portName in SerialPort.GetPortNames())
                {
                    if (this.BadPortList.IndexOf(portName) != -1)
                        continue;
                    PortData tempPort = new PortData(portName, 9600, Parity.None);
                    tempPort.ReceiveEventFlag = true;
                    //tempPort.Received -= new PortDataReceivedEventHandle(this.tempPort_Received);
                    if (tempPort.Open())
                    {
                        //发送测试命令
                        string command = "F70000";
                        // for (int i = 0; i < 5; i++)
                        //{
                        byte[] receiveData = new byte[2];
                        tempPort.SendCommand(command, ref receiveData, 5);
                        string receiveString = Lib.byteToHexStr(receiveData);
                        if (receiveString.Length == 4 && receiveString == command.Substring(0, 4))
                        {
                            this.portData = tempPort;
                            this.IsOld = false;
                            return true;
                        }
                        else
                        {
                            this.BadPortList.Add(portName);
                            tempPort.Close();
                        }
                    }
                }
                //portData.Close();
                //portData = null;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void LoadSerialMenuItem()
        {
            this.MenuItem_Serial.Visible = true;
            foreach (string portName in SerialPort.GetPortNames())
            {
                //this.comboBox_Serial.Items.Add(portName);

                ToolStripMenuItem SerialItem = new ToolStripMenuItem(portName);
                SerialItem.Click += new EventHandler(SerialItem_Click);
                MenuItem_Serial.DropDownItems.Add(SerialItem);
            }
        }

        void SerialItem_Click(object sender, EventArgs e)
        {
  
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Checked)
            {
                if (portData.IsOpen())
                {
                    portData.Close();
                    item.Checked = false;
                    portData = null;
                }

                item.Visible = false;
                    
            }
            else
            {
                foreach (ToolStripMenuItem childItem in MenuItem_Serial.DropDownItems)
                {
                    childItem.Checked = false;
                }
                if (portData != null)
                {
                    portData.Close();
                    portData = null;
                }
                portData = new PortData(item.Text, 9600, Parity.None);
                portData.Received += new PortDataReceivedEventHandle(this.portData_Received);
                portData.Open();
                item.Checked = true;
            }
        }


        public void ShowCharting(int Type, DataSet ds)
        {
            switch (Type)
            {
                case 0:
                    ZendChart chart = new ZendChart();
                    chart.Dock = DockStyle.Fill;
                    this.panel_charting.Controls.Clear();
                    this.panel_charting.Controls.Add(chart);
                    chart.ShowCharting(ds);
                    break;
                case 1:
                    UC_DataGridCharting gridCharting = new UC_DataGridCharting();
                    gridCharting.Dock = DockStyle.Fill;
                    this.panel_charting.Controls.Clear();
                    this.panel_charting.Controls.Add(gridCharting);
                    gridCharting.ShowCharting(ds);
                    break;
                case 2:
                    ZendChart chartOneTime = new ZendChart();
                    chartOneTime.groupBox4.Enabled = false;
                    chartOneTime.Dock = DockStyle.Fill;
                    this.panel_charting.Controls.Clear();
                    this.panel_charting.Controls.Add(chartOneTime);
                    chartOneTime.ShowChartingForOneTime(ds);
                    break;
                case 3: //启动时默认显示方式
                    UC_DataGridCharting gridChartingDefault = new UC_DataGridCharting();
                    gridChartingDefault.Dock = DockStyle.Fill;
                    this.panel_charting.Controls.Clear();
                    this.panel_charting.Controls.Add(gridChartingDefault);
                    this.MainControl = gridChartingDefault;
                    break;
            }
        }

        public void UpdateCollectInfoTree()
        {
            this.MainControl.dataTree1.LoadData();
        }
        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 清空数据CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.userControl_SerialCommControl1.button2_Click(null, null);
        }

        private void 读取数据RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.userControl_SerialCommControl1.button3_Click(null, null);
        }

        private void 导出数据OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoseOupputDataType OutPut = new ChoseOupputDataType();
            OutPut.Show(this);
            //this.userControl_SerialCommControl1.button_outputData_Click(null, null);
        }

        private void 导入数据RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputData input = new InputData();
            input.ShowDialog();
            return;
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
            //this.userControl_SerialCommControl1.button_inputData_Click(null, null);
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.ShowDialog();
        }
        public void ShowDialog(Form form,ArrayList param)
        {

            form.ShowDialog();
        }

        //串口操作
        public StringBuilder SerialString = new StringBuilder();
        public void portData_Received(object sender, PortDataReciveEventArgs e)
        {

            string HexStr = Lib.byteToHexStr(e.Data);
            this.SerialString.Append(HexStr);

            //ShowDegete show = new ShowDegete(this.ShowResult);
            //Invoke(show, new object[]{HexStr});
            //show(HexStr);
            //MessageBox.Show(HexStr);
        }

        private void 打开串口OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 校时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (portData == null)
            {
                MessageBox.Show("串口还未打开，请先打开!");
                return;
            }
            SetMachineTime set = new SetMachineTime(this.portData);
            set.ShowDialog();
        }

        private void 清空数据表CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.portData == null)
            {
                MessageBox.Show("串口还未打开，请先打开!");
                return;
            }
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

        private void 读取数据RToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "FA0000";
                if (portData == null)
                {
                    MessageBox.Show("串口还未打开，请先打开!");
                    return;
                }
                this.SerialString = new StringBuilder();
                portData.port.DiscardInBuffer();
                portData.SendCommand(command);
                //System.Threading.Thread.Sleep(10000);
                
                getCollectorData get = new getCollectorData(this.SerialString);
                DialogResult result = get.ShowDialog();
                if (result == DialogResult.Cancel)
                    portData.port.DiscardInBuffer();
                if (result == DialogResult.OK)
                {
                    Program.mainForm.ShowCharting(3, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取数据失败" + Environment.NewLine + "错误信息:" + ex.Message);
            }
        }

        private void 普通绘图PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZendChart zend = new ZendChart();
            zend.Show(this);
        }

        private void 单时间点绘图SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneTimeZendChart zend = new OneTimeZendChart();
            zend.Show();
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetProperty set = new SetProperty();
            set.ShowDialog();
        }

        private void 定时导出TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutPutDataTimerSetting set = new OutPutDataTimerSetting();
            set.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.校时ToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            this.读取数据RToolStripMenuItem1_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.清空数据表CToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.导出数据OToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.导入数据RToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.定时导出TToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.普通绘图PToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.单时间点绘图SToolStripMenuItem_Click(null, null);
        }

        private void MenuItem_Serial_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭串口
            if (this.portData != null)
                if (this.portData.port != null && this.portData.port.IsOpen == false)
                    this.portData.port.Close();
        }

        private void office2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            this.ChangePaletteMode("Office2007Blue");
        }

        private void office2007ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.ChangePaletteMode("Office2007Silver");
        }

        private void office2003ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.ChangePaletteMode("ProfessionalOffice2003");
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangePaletteMode("Office2007Black");
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            this.ChangePaletteMode("ProfessionalSystem");
        }
        public void ChangePaletteMode(string PaletteName)
        {
            try
            {
                this.kryptonManager.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteModeManager), PaletteName, false);
                Lib.UpdateApplicationSetting("ThemeName", PaletteName);
            }
            catch (Exception ex)
            {
                this.kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
        }
    }
}
