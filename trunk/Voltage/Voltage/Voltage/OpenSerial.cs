using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Voltage
{
    public partial class OpenSerial : Form
    {
        private PortData portData;
        public OpenSerial(PortData portData)
        {
            this.portData = portData;
            InitializeComponent();
        }

        private void button_OpenSerial_Click(object sender, EventArgs e)
        {
            if (this.portData==null)
            {
                portData = new PortData(this.comboBox_Serial.Text, 9600, Parity.None);
                portData.Received += new PortDataReceivedEventHandle(Program.mainForm.portData_Received);
                portData.Open();
                this.comboBox_Serial.Enabled = false;
                this.button_OpenSerial.Text = "关闭串口";
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.portData.Close();
                this.portData = null;
                this.comboBox_Serial.Enabled = true;
                this.button_OpenSerial.Text = "打开串口";
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void OpenSerial_Load(object sender, EventArgs e)
        {
            foreach (string portName in SerialPort.GetPortNames())
            {
                this.comboBox_Serial.Items.Add(portName);
            }
            if (this.comboBox_Serial.Items.Count > 0)
                this.comboBox_Serial.SelectedIndex = 0; 
        }
    }
}
