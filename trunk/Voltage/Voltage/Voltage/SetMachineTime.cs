using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class SetMachineTime : Form
    {
        private PortData portData;
        public SetMachineTime(PortData portData)
        {
            this.portData = portData;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetTime();
        }
        public void SetTime()
        {
            if (portData == null)
            {
                MessageBox.Show("还没有打开串口,请先打开串口!");
                return;
            }
            try
            {
                decimal data = this.numericUpDown_date.Value;
                string DataStr = data.ToString();
                if (data.ToString().Length == 1)
                    DataStr = "0" + data.ToString();
                string command = "F" + this.comboBox_SetdateType.SelectedIndex.ToString() + DataStr.ToString() + "00";
                byte[] receiveData = new byte[2];
                portData.SendCommand(command, ref receiveData, 1000);
                string receiveString = Lib.byteToHexStr(receiveData);
                if (receiveString.Length==4&&receiveString == command.Substring(0, 4))
                    MessageBox.Show("设置成功");
                else
                    MessageBox.Show("设置失败，串口未返回正确数据，请连接正确的下位机！");

            }
            catch (Exception ex)
            {
                MessageBox.Show("设置失败" + Environment.NewLine + "错误信息:" + ex.Message);
            }
        }

        private void SetMachineTime_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.comboBox_SetdateType.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (portData == null)
            {
                MessageBox.Show("还没有打开串口,请先打开串口!");
                return;
            }
            try
            {
                DateTime dt = this.dateTimePicker1.Value;
                this.SetTime2(0, dt.Year);
                
                this.SetTime2(1, dt.Month);
                this.SetTime2(2, dt.Day);
                this.SetTime2(3, dt.Hour);
                this.SetTime2(4, dt.Minute);
                this.SetTime2(5, dt.Second);
                MessageBox.Show("设置成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("设置失败" + Environment.NewLine + "错误信息:" + ex.Message);
            }
        }
        public bool SetTime2(int type, int data)
        {
            string command = "";
            if (data.ToString().Length != 4)
            {
                command = "F" + type.ToString() + (data.ToString().Length == 1 ? "0" + data.ToString() : data.ToString()) + "00";
            }
            else
                command = "F" + type.ToString() + data.ToString().Substring(2, 2) + "00";
            byte[] receiveData = new byte[2];
            portData.SendCommand(command, ref receiveData, 1000);
            System.Threading.Thread.Sleep(1000);
            string receiveString = Lib.byteToHexStr(receiveData);
            if (receiveString.Length == 4 && receiveString == command.Substring(0, 4))
                return true;
            else
                return false;
        }

        private void comboBox_SetdateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox_SetdateType.SelectedIndex)
            {
                case 0:
                    this.numericUpDown_date.Minimum = 0;
                    this.numericUpDown_date.Maximum = 99;
                    break;
                case 1:
                    this.numericUpDown_date.Minimum = 1;
                    this.numericUpDown_date.Maximum = 12;
                    break;
                case 2:
                    this.numericUpDown_date.Minimum = 1;
                    this.numericUpDown_date.Maximum = 31;
                    break;
                case 3:
                    this.numericUpDown_date.Minimum = 1;
                    this.numericUpDown_date.Maximum = 24;
                    break;
                default:
                    this.numericUpDown_date.Minimum = 1;
                    this.numericUpDown_date.Maximum = 60;
                    break;
            }
        }
    }
}
