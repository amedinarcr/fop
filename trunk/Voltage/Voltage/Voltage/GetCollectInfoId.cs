using System;
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
        public GetCollectInfoId()
        {
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
    }
}
