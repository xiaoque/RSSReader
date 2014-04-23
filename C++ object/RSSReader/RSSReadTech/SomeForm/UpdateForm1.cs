using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RSSReadTech.Rss;
using RSSReadTech.Work;

namespace RSSReadTech.SomeForm
{
    public partial class UpdateForm1 : Form
    {
        //定义一个泛型List<ReadRssLinks>记录频道
        private List<ReadRssLinks> readRssLinks;
        //定义一个类RssChannel的实例rssChannel记录频道具体信息
        private RssChannel rssChannel;
        //用字段isUpdateorDelete判断是修改还是删除，修改为true，删除为false
        private bool isUpdateorDelete;
       
        public bool IsUpdateorDelete
        {
            get { return isUpdateorDelete; }
            set { isUpdateorDelete = value; }
        }
        //用字段SelectNode记录选择的节点是频道还是元素
        private TreeNode SelectNode;

        public UpdateForm1()
        {
            InitializeComponent();
        }

        private void UpdateForm1_Load(object sender, EventArgs e)
        {
            
            if(isUpdateorDelete)
            {
                this.Width = this.Width - splitContainer1.Panel1.Width;
                splitContainer1.Panel1Collapsed = true;
                this.Text = "修改";
            }
            else
            {
                this.Width = this.Width - splitContainer1.Panel2.Width;
                splitContainer1.Panel2Collapsed = true;
                this.Text = "删除";
            }
            ShowForm();
        }
        //单击节点触发的事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txbselectname.Text = e.Node.Text;
            txbdeletename.Text = e.Node.Text;
            SelectNode = e.Node;
        }
        //判断txbselectname中是否有内容而决定修改按钮是否可用
        private void txbselectname_TextChanged(object sender, EventArgs e)
        {
            if(txbselectname.Text.Length!=0)
            {
                btnupdate.Enabled = true;
            }
        }
        private void txbdeletename_TextChanged(object sender, EventArgs e)
        {
            if(txbdeletename.Text.Length!=0)
            {
                btndelete.Enabled = true;
            }
        }
        //点击修改按钮触发的事件
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(SelectNode.Tag==null)
            {
                UPdateForm2 myUPdateForm2 = new UPdateForm2();
                myUPdateForm2.Oldname = SelectNode.Text;
                myUPdateForm2.ShowDialog();
                Close();
            }
            else
            {
                UpdateForm3 myUpdateForm3 = new UpdateForm3();
                myUpdateForm3.Oldname = SelectNode.Text;
                myUpdateForm3.Fathername = SelectNode.Parent.Text;
                myUpdateForm3.Oldlink = SelectNode.Tag.ToString();
                myUpdateForm3.ShowDialog();
                Close();
            }
        }
        //点击取消按钮关闭窗口
        private void btncencel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //点击取消按钮关闭窗口
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //点击删除按钮触发的事件
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (SelectNode.Tag == null)
            {
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.DeleteChannel(txbdeletename.Text);
                MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.DeleteItem(SelectNode.Parent.Text,txbdeletename.Text, SelectNode.Tag.ToString());
                MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK);
                Close();
            }
        }
        private void ShowForm()
        {  
            IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
            readRssLinks = myIRssLink.ReadRssLink();
            foreach (ReadRssLinks r in readRssLinks)
            {
                if (r.Defaultshow)
                {
                    TreeNode node = new TreeNode();
                    node.Text = r.Title;
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    rssChannel = new RssChannel(r.Uri);
                    if (r.Defaultshow)
                    {
                        foreach (RssItem rs in rssChannel.Items)
                        {
                            TreeNode chnode = new TreeNode();
                            chnode.Text = rs.Title;
                            chnode.Tag = rs.Link;
                            chnode.ImageIndex = 1;
                            chnode.SelectedImageIndex = 1;
                            node.Nodes.Add(chnode);
                        }
                        treeView1.Nodes.Add(node);
                    }
                }
            }

        }

        

       

       

        

        

        

       

       
    }
}