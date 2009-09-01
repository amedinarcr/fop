using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Drawing.Drawing2D;
using System.Data.OleDb;

namespace Voltage
{
    public partial class SetCollectProperty : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public LineItem lineItem;
        public string CollectId;
        public bool isExist;
        public SetCollectProperty(LineItem lineItem,string CollectId)
        {
            InitializeComponent();
            this.lineItem = lineItem;
            this.CollectId = CollectId;
            this.label_CollectId.Text = CollectId.ToString();
            this.comboBox_LineStyle.SelectedIndex = 0;           
            this.comboBox_SymbolType.DataSource = Enum.GetNames(typeof(SymbolType));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.textBox_LineColor.BackColor = this.colorDialog1.Color;
            //if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.textBox_LineColor.BackColor = this.colorDialog1.Color;               
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save property
            if (this.isExist)
            {
                string updateSql = "Update CollectInfo set ProtectStationName=@ProtectStationName,TestPileID=@TestPileID,PipelineName=@PipelineName,Mileage=@Mileage,Latitude=@Latitude,Remark=@Remark,"
                    + "LineWidth=@LineWidth,LineStyle=@LineStyle,LineColor=@LineColor,SymbolType=@SymbolType"
                    + " where ID=" + this.CollectId;
                OleDbParameter p_ProtectStationName = new OleDbParameter("@ProtectStationName", this.textBox_ProtectStationName.Text);
                OleDbParameter p_TestPileID = new OleDbParameter("@TestPileID", this.textBox_TestPileID.Text);
                OleDbParameter p_PipelineName = new OleDbParameter("@PipelineName", this.textBox_PipelineName.Text);
                OleDbParameter p_Mileage = new OleDbParameter("@Mileage", this.textBox_Mileage.Text);

                string Latitude = "";
                Latitude = this.inputMeasure1.Text + "&" + this.inputMeasure2.Text;
                OleDbParameter p_Latitude = new OleDbParameter("@Latitude", Latitude);

                OleDbParameter p_Remark = new OleDbParameter("@Remark", this.textBox_remark.Text);
                OleDbParameter p_LineWidth = new OleDbParameter("@LineWidth", this.numericUpDown_LineWidth.Value);
                p_LineWidth.OleDbType = OleDbType.Integer;
                OleDbParameter p_LineStyle = new OleDbParameter("@LineStyle", this.comboBox_LineStyle.SelectedIndex);
                p_LineStyle.OleDbType = OleDbType.Integer;
                OleDbParameter p_LineColor = new OleDbParameter("@LineColor",this.kryptonColorButton1.SelectedColor.ToArgb().ToString());
                p_LineColor.OleDbType = OleDbType.Integer;
                OleDbParameter p_SymbolType = new OleDbParameter("@SymbolType", this.comboBox_SymbolType.SelectedIndex);
                p_SymbolType.OleDbType = OleDbType.Integer;

              
                OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, updateSql, new OleDbParameter[] { p_ProtectStationName, p_TestPileID, p_PipelineName, p_Mileage,p_Latitude, p_Remark, p_LineWidth, p_LineStyle, p_LineColor, p_SymbolType });

            }
            else
            {
                string insertSql = "insert into CollectInfo(CollectId,ProtectStationName,TestPileID,PipelineName,Mileage,Latitude,Remark,LineWidth,LineStyle,LineColor,SymbolType) values(@CollectId,@ProtectStationName,@TestPileID,@PipelineName,@Mileage,@Latitude,@Remark,@LineWidth,@LineStyle,@LineColor,@SymbolType)";
                OleDbParameter p_CollectId = new OleDbParameter("@CollectId", this.label_CollectId.Text);
                OleDbParameter p_ProtectStationName = new OleDbParameter("@ProtectStationName", this.textBox_ProtectStationName.Text);
                OleDbParameter p_TestPileID = new OleDbParameter("@TestPileID", this.textBox_TestPileID.Text);
                OleDbParameter p_PipelineName = new OleDbParameter("@PipelineName", this.textBox_PipelineName.Text);
                OleDbParameter p_Mileage = new OleDbParameter("@Mileage", this.textBox_Mileage.Text);

                string Latitude = "";
                Latitude = this.inputMeasure1.Text + "&" + this.inputMeasure2.Text;
                OleDbParameter p_Latitude = new OleDbParameter("@Latitude", Latitude);

                OleDbParameter p_Remark = new OleDbParameter("@Remark", this.textBox_remark.Text);
                OleDbParameter p_LineWidth = new OleDbParameter("@LineWidth", this.numericUpDown_LineWidth.Value);
                p_LineWidth.OleDbType = OleDbType.Integer;
                OleDbParameter p_LineStyle = new OleDbParameter("@LineStyle", this.comboBox_LineStyle.SelectedIndex);
                p_LineStyle.OleDbType = OleDbType.Integer;
                OleDbParameter p_LineColor = new OleDbParameter("@LineColor", this.kryptonColorButton1.SelectedColor.ToArgb());
                p_LineColor.OleDbType = OleDbType.Integer;
                OleDbParameter p_SymbolType = new OleDbParameter("@SymbolType", this.comboBox_SymbolType.SelectedIndex);
                p_SymbolType.OleDbType = OleDbType.Integer;
                OleHelper.ExecuteNonQuery(OleHelper.Conn, CommandType.Text, insertSql, new OleDbParameter[] { p_CollectId, p_ProtectStationName, p_TestPileID, p_PipelineName, p_Mileage,p_Latitude, p_Remark, p_LineWidth, p_LineStyle, p_LineColor, p_SymbolType });
            }
            if (this.lineItem != null)
            {
                lineItem.Line.Width = Convert.ToInt16(this.numericUpDown_LineWidth.Value);
                lineItem.Line.Style = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox_LineStyle.SelectedIndex.ToString());
                lineItem.Line.Color = this.kryptonColorButton1.SelectedColor;

                lineItem.Symbol.Type = (SymbolType)Enum.Parse(typeof(SymbolType), this.comboBox_SymbolType.Text);
                lineItem.Symbol.Border.Color = lineItem.Line.Color;
                lineItem.Symbol.Fill = new Fill(lineItem.Line.Color);
                lineItem.Symbol.Size = 4.0F;
            }
            this.DialogResult = DialogResult.OK;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetLineItemProperty_Load(object sender, EventArgs e)
        {
            //load property
            try
            {
                DataSet ds = OleHelper.ExecuteDataset(OleHelper.Conn, CommandType.Text, "Select * from CollectInfo where Id=" + this.CollectId);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.isExist = true;
                    DataRow row = ds.Tables[0].Rows[0];
                    this.numericUpDown_LineWidth.Value = Convert.ToDecimal(row["LineWidth"].ToString());
                    this.comboBox_LineStyle.SelectedIndex = Convert.ToInt32(row["LineStyle"].ToString());
                    //this.textBox_LineColor.BackColor = Color.FromArgb(Convert.ToInt32(row["LineColor"].ToString()));
                    this.kryptonColorButton1.SelectedColor = Color.FromArgb(Convert.ToInt32(row["LineColor"].ToString()));
                    this.comboBox_SymbolType.SelectedIndex = Convert.ToInt32(row["SymbolType"].ToString());

                    this.textBox_ProtectStationName.Text = row["ProtectStationName"].ToString();
                    this.textBox_PipelineName.Text = row["PipelineName"].ToString();
                    this.textBox_Mileage.Text = row["Mileage"].ToString();
                    this.textBox_TestPileID.Text = row["TestPileID"].ToString();
                    string Latitude = row["Latitude"].ToString();
                    //this.textBox_Latitude.Text = 

                    this.inputMeasure1.Text = Latitude.Substring(0, Latitude.IndexOf('&'));
                    this.inputMeasure2.Text = Latitude.Substring(Latitude.IndexOf('&') + 1);
                    this.textBox_remark.Text = row["Remark"].ToString();
                    //this.comboBox_SymbolType.Text = Enum.GetName(typeof(SymbolType), (SymbolType)Enum.Parse(typeof(SymbolType),row["SymbolType"].ToString()));
                }
                else
                {
                    this.isExist = false;
                    this.kryptonColorButton1.SelectedColor = Color.Red;
                    this.textBox_ProtectStationName.Text = Voltage.Properties.Settings.Default.ProtectStationName;
                    this.textBox_PipelineName.Text = Voltage.Properties.Settings.Default.PipelineName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("加载属性失败!");
                DialogResult = DialogResult.Abort;
                this.Close();
            }
    
        }


        private void textBox_TestPileID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
