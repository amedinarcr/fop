using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Voltage
{
    public partial class DataTree : UserControl
    {
        public DataTree()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void DataTree_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public void LoadData()
        {
            DataSet CollectInfoDataSet = OleHelper.ExecuteDataset("Select * from CollectInfo");
            foreach (DataRow row in CollectInfoDataSet.Tables[0].Rows)
            {
                if (this.treeView1.Nodes.IndexOfKey("PipeLineName_" + row["PipeLineName"].ToString()) == -1)
                {
                    string PipeLineName = row["PipeLineName"].ToString();
                    if (PipeLineName.Trim() == string.Empty)
                        PipeLineName = "(无管线名)";
                    TreeNode PipeLineNameNode = new TreeNode(PipeLineName);
                    PipeLineNameNode.Name = "PipeLineName_" + row["PipeLineName"].ToString();
                    //PipeLineNameNode.Tag = row["ID"].ToString();
                    this.treeView1.Nodes.Add(PipeLineNameNode);
                }
            }

            //绑定保护站
            foreach (DataRow row in CollectInfoDataSet.Tables[0].Rows)
            {
                TreeNode PipeLineNameNode = this.treeView1.Nodes.Find("PipeLineName_" + row["PipeLineName"].ToString(),false)[0];
                if (PipeLineNameNode.Nodes.IndexOfKey("ProtectStationName_" + row["ProtectStationName"].ToString()) == -1)
                {
                    string ProtectStationName = row["ProtectStationName"].ToString();
                    if (ProtectStationName.Trim() == string.Empty)
                        ProtectStationName = "(无保护站名称)";
                    TreeNode node = new TreeNode(ProtectStationName);
                    node.Name = "ProtectStationName_" + row["ProtectStationName"].ToString();             
                    PipeLineNameNode.Nodes.Add(node);
                }
            }
        
            //绑定采集器编号
            foreach (DataRow row in CollectInfoDataSet.Tables[0].Rows)
            {
                TreeNode ProtectStationNameNode = this.treeView1.Nodes.Find("ProtectStationName_" + row["ProtectStationName"].ToString(), true)[0];
                if (ProtectStationNameNode.Nodes.IndexOfKey("CollectId_" + row["CollectId"].ToString()) == -1)
                {
                    TreeNode node = new TreeNode(row["CollectId"].ToString());
                    node.Name = row["CollectId"].ToString();
                    ProtectStationNameNode.Nodes.Add(node);                    
                }
            }
        }
    }
}
