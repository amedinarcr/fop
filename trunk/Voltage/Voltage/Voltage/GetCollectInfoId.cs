using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Voltage
{
    public partial class GetCollectInfoId : KryptonForm
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
            this.buttonSpecAny1.Click += new EventHandler(buttonSpecAny1_Click);
            this.buttonSpecAny2.Click += new EventHandler(buttonSpecAny2_Click);
            TreeView treeView = this.dataTree1.treeView1;
            treeView.CheckBoxes = true;
            treeView.AfterCheck += new TreeViewEventHandler(treeView_AfterCheck);
            treeView.AfterSelect -= new TreeViewEventHandler(this.dataTree1.treeView1_AfterSelect);
        }

        void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.GetNode(this.dataTree1.treeView1.Nodes[0]);
            DialogResult = DialogResult.OK;
        }

        void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
