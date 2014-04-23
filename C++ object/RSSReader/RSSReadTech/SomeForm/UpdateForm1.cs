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
        //����һ������List<ReadRssLinks>��¼Ƶ��
        private List<ReadRssLinks> readRssLinks;
        //����һ����RssChannel��ʵ��rssChannel��¼Ƶ��������Ϣ
        private RssChannel rssChannel;
        //���ֶ�isUpdateorDelete�ж����޸Ļ���ɾ�����޸�Ϊtrue��ɾ��Ϊfalse
        private bool isUpdateorDelete;
       
        public bool IsUpdateorDelete
        {
            get { return isUpdateorDelete; }
            set { isUpdateorDelete = value; }
        }
        //���ֶ�SelectNode��¼ѡ��Ľڵ���Ƶ������Ԫ��
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
                this.Text = "�޸�";
            }
            else
            {
                this.Width = this.Width - splitContainer1.Panel2.Width;
                splitContainer1.Panel2Collapsed = true;
                this.Text = "ɾ��";
            }
            ShowForm();
        }
        //�����ڵ㴥�����¼�
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txbselectname.Text = e.Node.Text;
            txbdeletename.Text = e.Node.Text;
            SelectNode = e.Node;
        }
        //�ж�txbselectname���Ƿ������ݶ������޸İ�ť�Ƿ����
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
        //����޸İ�ť�������¼�
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
        //���ȡ����ť�رմ���
        private void btncencel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //���ȡ����ť�رմ���
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //���ɾ����ť�������¼�
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (SelectNode.Tag == null)
            {
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.DeleteChannel(txbdeletename.Text);
                MessageBox.Show("ɾ���ɹ�", "�ɹ�", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.DeleteItem(SelectNode.Parent.Text,txbdeletename.Text, SelectNode.Tag.ToString());
                MessageBox.Show("ɾ���ɹ�", "�ɹ�", MessageBoxButtons.OK);
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