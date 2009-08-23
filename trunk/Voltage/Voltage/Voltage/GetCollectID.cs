using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class GetCollectID : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public ArrayList resultList;
        public GetCollectID(ArrayList list,string [] inList)
        {
            resultList = list;
            InitializeComponent();
            foreach (string str in inList)
                if (str.Trim('\'') != "")
                    this.listBox_Des.Items.Add(str.Trim('\''));
        }
        public GetCollectID(ArrayList list)
        {
            resultList = list;
            InitializeComponent();    
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<this.listBox_Source.Items.Count;i++)
            {
                if (this.listBox_Source.GetSelected(i))
                {
                    string sourceValue = this.listBox_Source.Items[i].ToString();
                    if (this.listBox_Des.FindString(sourceValue.ToString(), 0) == -1)
                        if (sourceValue.Trim() != "")
                            this.listBox_Des.Items.Add(sourceValue);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox_Des.Items.Clear();
            foreach (string str in this.listBox_Source.Items)
            {
                this.listBox_Des.Items.Add(str);
            }
        }

        private void GetCollectID_Load(object sender, EventArgs e)
        {
            DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "Select distinct CollectId from DataTable");
            foreach(DataRow  row in ds.Tables[0].Rows)
            {
                this.listBox_Source.Items.Add(row["CollectId"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listBox_Des.Items.Count; i++)
            {
                if (this.listBox_Des.GetSelected(i))
                {
                    this.listBox_Des.Items.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listBox_Des.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            foreach (string str in this.listBox_Des.Items)
            {
                strBuilder.Append("'"+str+"'"+",");

            }
            if (this.listBox_Des.Items.Count > 0)
                strBuilder.Remove(strBuilder.Length - 1, 1);
            this.resultList.Add(strBuilder.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
