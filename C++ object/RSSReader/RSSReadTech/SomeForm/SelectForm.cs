using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RSSReadTech.Rss;

namespace RSSReadTech.SomeForm
{
    public partial class SelectForm : Form
    {
        private TreeNode selectNode;
        public SelectForm()
        {
            InitializeComponent();
        }

        //单击浏览按钮打开openFileDialog1控件的事件
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txbaddress.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //点击查询按钮触发的事件
        private void bntselect_Click(object sender, EventArgs e)
        {
            SelectXml(txbaddress.Text);
        }
        //根据txbaddress是否有内容判断查询按钮是否启用
        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            if (txbaddress.Text.Length != 0)
            {
                bntselect.Enabled = true;
            }
        }
        //点击取消按钮触发的事件
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //用户选择节点触发事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectNode = e.Node;
            btnadd.Enabled = true;
        }
        //点击添加按钮触发的事件
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                RssChannel myRssChannel = new RssChannel(selectNode.Tag.ToString());
                AddForm myAddForm = new AddForm();
                myAddForm.IsShowbackbtn = true;
                myAddForm.Uri = selectNode.Tag.ToString();
                myAddForm.ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("RSS文件格式不正确！", "文件错误", MessageBoxButtons.OK);
            }
        }
        //查询选择目录下的XML文件
        private void SelectXml(string mulu)
        {
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(mulu);
            FileInfo[] files = myDirectoryInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                if (IsXml(f.Name))
                {
                    TreeNode node = new TreeNode(f.Name);
                    node.Tag = f.FullName;
                    treeView1.Nodes.Add(node);
                }
            }
        }
        //判断文件是否为xml文件
        private bool IsXml(string name)
        {
            bool isXml = false;
            if (name.Substring(name.Length - 3) == "xml")
            {
                isXml = true;
            }

            return isXml;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.Text = "查找RSS文件";
        }

       

       
    }
}