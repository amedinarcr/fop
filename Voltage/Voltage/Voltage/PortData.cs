using System;
using System.Collections.Generic;

using System.Text;
using System.IO.Ports;

namespace Voltage
{
public class PortData
    {
        public event PortDataReceivedEventHandle Received;
        public event SerialErrorReceivedEventHandler Error; 
        public SerialPort port;
        public bool ReceiveEventFlag = false;  //接收事件是否有效 false表示有效

        public PortData(string sPortName, int baudrate,Parity parity)
        {
            port = new SerialPort(sPortName, baudrate, parity, 8, StopBits.One);
            port.RtsEnable = true;
            port.ReadTimeout = 3000;
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            port.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorEvent);
        }

        ~PortData()
        {
            Close();
        }
        public bool Open()
        {
            if (!port.IsOpen)
            {
                try
                {
                    port.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
                return true;
        }

        public void Close()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }
        //数据发送
        public void SendData(byte[] data)
        {
            if (port.IsOpen)
            {
                port.Write(data, 0, data.Length);
            }
        }
        public void SendData(byte[] data,int offset,int count)
        {
            if (port.IsOpen)
            {
                port.Write(data, offset, count);
            }
        }
        //发送命令
        public int SendCommand(string SendData, ref  byte[] ReceiveData,int Overtime)
        {

            if(port.IsOpen)
            {
                ReceiveEventFlag = true;        //关闭接收事件
                port.DiscardInBuffer();         //清空接收缓冲区     
                byte[] Data = Lib.strToToHexByte(SendData);
                port.Write(Data, 0, Data.Length);
                int num=0,ret=0;
                while (num++ < Overtime)
                {
                    if (port.BytesToRead >= ReceiveData.Length) break;
                    System.Threading.Thread.Sleep(100); 
                }
                if (port.BytesToRead == ReceiveData.Length) 
                    ret = port.Read(ReceiveData, 0, ReceiveData.Length);
                ReceiveEventFlag = false;       //打开事件
                return ret;
            }
            return -1;
        }

           /// <summary>
           /// send Command but no return
           /// </summary>
           /// <param name="SendData"></param>
           /// <param name="ReceiveData"></param>
           /// <param name="Overtime"></param>
           /// <returns></returns>
        public void SendCommand(string hexString)
        {

            if(port.IsOpen)
            {
                //ReceiveEventFlag = true;        //关闭接收事件
                port.DiscardInBuffer();        //Clear Buffer     
                byte[] data = Lib.strToToHexByte(hexString);
                port.Write(data, 0, data.Length);
            }   

        }

        
        public void ErrorEvent(object sender, SerialErrorReceivedEventArgs e)
        {
            if (Error != null) Error(sender, e);
        }
        //数据接收
        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //禁止接收事件时直接退出
            if (ReceiveEventFlag) return;
            try
            {
                if (port.IsOpen)
                {


                    byte[] data = new byte[port.BytesToRead];
                    port.Read(data, 0, data.Length);
                    if (Received != null) Received(sender, new PortDataReciveEventArgs(data));

                }
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show("读取端口失败，请正确连接下位机!\n详细错误信息:\n\t" + ex.Message);
            }
        }

        public bool IsOpen()
        {
            return port.IsOpen;
        }
    }
    public delegate void PortDataReceivedEventHandle(object sender, PortDataReciveEventArgs e);
    public class PortDataReciveEventArgs : EventArgs
    {
        public PortDataReciveEventArgs()
        {
            this.data = null;
        }

        public PortDataReciveEventArgs(byte[] data)
        {
            this.data = data;
        }

        private byte[] data;

        public byte[] Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}


