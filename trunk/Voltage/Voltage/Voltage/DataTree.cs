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
        public UC_DataGridCharting grid;
        public DataTree()
        {
            
            InitializeComponent();
        }

        public DataTree(UserControl grid)
        {
            this.grid = grid as UC_DataGridCharting;
            InitializeComponent();
        }
        public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name.Substring(0, e.Node.Name.IndexOf('_')))
            {
                case "CollectId":
                    string CollectInfoId = e.Node.Name.Substring(e.Node.Name.IndexOf('_') + 1);
                    this.grid.ShowData("(" + CollectInfoId + ")");
                    break;

                case "ProtectStationName":
                    System.Collections.ArrayList CollectInfoList = new System.Collections.ArrayList();
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        CollectInfoList.Add(node.Name.Substring(node.Name.IndexOf('_') + 1));
                    }
                    this.grid.ShowCollectInfo(CollectInfoList);
                    break;

                case "PipeLineName":
                    CollectInfoList = new System.Collections.ArrayList();                  
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        foreach (TreeNode CollectNode in node.Nodes)
                        {
                            CollectInfoList.Add(CollectNode.Name.Substring(CollectNode.Name.IndexOf('_') + 1));
                        }
                    }
                    this.grid.ShowCollectInfo(CollectInfoList);
                    break;

                case "Root":
                    this.grid.ShowAllCollectInfo();
                    break;
            }

        }

        private void DataTree_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public void LoadData()
        {

            this.treeView1.Nodes.Clear();
            this.treeView1.ImageList = this.imageList1;
            TreeNode rootNode = new TreeNode("管线");
            rootNode.Name = "Root_PipeLine";
            rootNode.ImageIndex = 3;
            rootNode.SelectedImageIndex = 3;
            this.treeView1.Nodes.Add(rootNode);

            DataSet CollectInfoDataSet = OleHelper.ExecuteDataset("Select * from CollectInfo");
            foreach (DataRow row in CollectInfoDataSet.Tables[0].Rows)
            {
                if (this.treeView1.Nodes[0].Nodes.IndexOfKey("PipeLineName_" + row["PipeLineName"].ToString()) == -1)
                {
                    string PipeLineName = row["PipeLineName"].ToString();
                    if (PipeLineName.Trim() == string.Empty)
                        PipeLineName = "(无管线名)";
                    TreeNode PipeLineNameNode = new TreeNode(PipeLineName);
                    PipeLineNameNode.Name = "PipeLineName_" + row["PipeLineName"].ToString();
                    //PipeLineNameNode.Tag = row["ID"].ToString();
                    PipeLineNameNode.ImageIndex = 0;
                    PipeLineNameNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(PipeLineNameNode);
                }
            }

            //绑定保护站
            foreach (DataRow row in CollectInfoDataSet.Tables[0].Rows)
            {
                TreeNode PipeLineNameNode = this.treeView1.Nodes.Find("PipeLineName_" + row["PipeLineName"].ToString(),true)[0];
                if (PipeLineNameNode.Nodes.IndexOfKey("ProtectStationName_" + row["ProtectStationName"].ToString()) == -1)
                {
                    string ProtectStationName = row["ProtectStationName"].ToString();
                    if (ProtectStationName.Trim() == string.Empty)
                        ProtectStationName = "(无保护站名称)";
                    TreeNode node = new TreeNode(ProtectStationName);
                    node.Name = "ProtectStationName_" + row["ProtectStationName"].ToString();
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
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
                    node.Name = "CollectId_"+row["ID"].ToString();
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    ProtectStationNameNode.Nodes.Add(node);                    
                }
            }

            this.treeView1.ExpandAll();
        }
    }
}
