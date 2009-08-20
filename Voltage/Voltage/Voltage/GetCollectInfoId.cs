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
    public partial class GetCollectInfoId : Form
    {
        public ArrayList CollectInfoList;
        public GetCollectInfoId()
        {
            InitializeComponent();
          
        }
        public GetCollectInfoId(ArrayList CollectInfoList)
        {
            this.CollectInfoList = CollectInfoList;
            InitializeComponent();
        }

        private void GetCollectInfoId_Load(object sender, EventArgs e)
        {
            TreeView treeView = this.dataTree1.treeView1;
            treeView.CheckBoxes = true;
            treeView.AfterCheck += new TreeViewEventHandler(treeView_AfterCheck);
            treeView.AfterSelect -= new TreeViewEventHandler(this.dataTree1.treeView1_AfterSelect);
        }

        void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeView treeView=sender as TreeView;

            if (e.Node.Nodes.Count > 0)
            {
              // foreach(TreeNode node in 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetNode(this.dataTree1.treeView1.Nodes[0]);
            DialogResult = DialogResult.OK;
        }

        public void GetNode(TreeNode parentNode)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Name.IndexOf("CollectId_") != -1&&node.Checked==true)
                    this.CollectInfoList.Add(node.Name.Substring(node.Name.IndexOf('_') + 1));
                if (node.Nodes.Count != 0)
                    this.GetNode(node);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
