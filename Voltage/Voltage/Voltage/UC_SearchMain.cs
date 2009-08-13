using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class UC_SearchMain : UserControl
    {
        public UC_SearchMain()
        {
            InitializeComponent();
        }

        private void UC_SearchMain_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("默认显示方式");
            this.comboBox1.Items.Add("图表方式");
            this.comboBox1.Items.Add("数据方式");
            this.comboBox1.Items.Add("单时间点图表方式");
            this.comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                
                case 0:
                    this.panel1.Controls.Clear();
                    Program.mainForm.ShowCharting(3,null);
                    break;
                case 1:
                
                    UC_DataGridSearchQuery  query= new UC_DataGridSearchQuery(0);
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(query);
                    break;
                case 2:
                    UC_DataGridSearchQuery GridViewQuery = new UC_DataGridSearchQuery(1);
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(GridViewQuery);
                    break;
                case 3:
                    UC_SearchOneTimeData oneTimeSearch = new UC_SearchOneTimeData();
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(oneTimeSearch);
                    break;
                    
                    
            }
        }
    }
}
