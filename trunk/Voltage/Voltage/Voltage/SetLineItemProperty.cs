using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Drawing.Drawing2D;

namespace Voltage
{
    public partial class SetLineItemProperty : Form
    {
        public LineItem lineItem;
        public SetLineItemProperty(LineItem lineItem)
        {
            InitializeComponent();
            this.lineItem = lineItem;
            this.comboBox_LineStyle.SelectedIndex = 0;           
            this.comboBox_SymbolType.DataSource = Enum.GetNames(typeof(SymbolType));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = lineItem.Line.Color;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox_LineColor.BackColor = this.colorDialog1.Color;
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save property
            lineItem.Line.Width = Convert.ToInt16(this.numericUpDown_LineWidth.Value);
            lineItem.Line.Style = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox_LineStyle.SelectedIndex.ToString());
            lineItem.Line.Color = this.textBox_LineColor.BackColor;

            lineItem.Symbol.Type = (SymbolType)Enum.Parse(typeof(SymbolType), this.comboBox_SymbolType.Text);
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetLineItemProperty_Load(object sender, EventArgs e)
        {
            //load property
            this.numericUpDown_LineWidth.Value = Convert.ToDecimal(lineItem.Line.Width);
            this.comboBox_LineStyle.SelectedIndex = (int)lineItem.Line.Style;
            this.textBox_LineColor.BackColor = lineItem.Line.Color;

            this.comboBox_SymbolType.Text = Enum.GetName(typeof(SymbolType), lineItem.Symbol.Type);
        }
    }
}
