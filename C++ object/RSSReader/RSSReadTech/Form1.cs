using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RSSReadTech.Rss;
using System.Xml;
using RSSReadTech.DBdata;
using RSSReadTech.SomeForm;
using RSSReadTech.Work;
namespace RSSReadTech
{
    public partial class Form1 : Form
    {
        //����һ������List<ReadRssLinks>��¼Ƶ��
        private List<ReadRssLinks> readRssLinks;

        internal List<ReadRssLinks> ReadRssLinks
        {
            get { return readRssLinks; }
            set { readRssLinks = value; }
        }
        //����һ����RssChannel��ʵ��rssChannel��¼Ƶ��������Ϣ
        private RssChannel rssChannel;
  
        public Form1()
        {
            InitializeComponent();
           
        }
        //�����ֶ�isgenxin��¼�Ƿ����
        private bool isgenxin;
        //�����ֶ�selectweb��¼ѡ�����ҳ
        private WebBrowser selectweb;
        //�����ֶ�uri��¼��ҳ����ַ
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isgenxin)
            {
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
                treeView1.Nodes.Clear();
                ShowForm();
                isgenxin = false;
                
            }
          
        }
        //ÿ�μ�����ҳ��ʱ�������¼�
        private void Form1_Load(object sender, EventArgs e) 
        {
            this.Text = "RSS�Ķ���";
            ShowForm();
        }
        //�û�˫���ڵ�ʱ�����¼�����ѡ�еĽڵ����ַ�¼�
         private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
             SelectTreeNode(e.Node);
             tsbopen.Enabled = false;
        }
        //�û�ֻ�����˫����ҳ�Ż�ر�
        private void tclweb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClosePage(e.Button == MouseButtons.Left);
        }
        //����cbxaddress�е���ҳ�¼�
        private void butgoto_Click(object sender, EventArgs e)
        {
            OpenPage(cbxaddress.Text);
        }
        //������淽ʽ��ť�������¼�����ShowRssForm����
        private void tsbchangesave_Click(object sender, EventArgs e)
        {
            ShowRssForm myShowRssForm = new ShowRssForm();
            myShowRssForm.ShowDialog();
        }
        //���Ƶ���洢��ť�������¼�����ShowRssForm����
        private void Ƶ���洢ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowRssForm myShowRssForm = new ShowRssForm();
            myShowRssForm.ShowDialog();

        }
        //��ҳˢ�µ��¼�
        private void tsbrenovate_Click(object sender, EventArgs e)
        {
            OpenPage(cbxaddress.Text);
        }
        //�е�ȫ����ʾ��ҳ�¼�
        private void tsbfull_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            tsbreturn.Visible = true;
            tsbfull.Visible = false;
        }
        //�˵����е��ȫ����ָ���ť�������¼�
        private void ��ʾƵ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }

        }
        //�ָ�Ƶ������ҳ������ʽ�¼�
        private void tsbreturn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            tsbreturn.Visible = false;
            tsbfull.Visible = true;
        }
        //�����ڵ�ʱ���ô򿪰�ť�¼�
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.ImageIndex == 1)
            {
                tsbopen.Enabled = true;
                tsbopen.Tag = e.Node;
            }
        }
        //�����򿪰�ť��Ƶ���¼�
        private void tsbopen_Click(object sender, EventArgs e)
        {
            SelectTreeNode((TreeNode)tsbopen.Tag);
            tsbopen.Enabled = false;
        }
        //�����˵����е�����Ƶ����ť���¼�����mySaveForm����
        private void ����Ƶ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm mySaveForm = new SaveForm();
            mySaveForm.ShowDialog();
            isgenxin = true;
        }
        //������Ƶ����ť����Ƶ���¼�����mySaveForm����
        private void tsbaddpindao_Click(object sender, EventArgs e)
        {
            SaveForm mySaveForm = new SaveForm();
            mySaveForm.ShowDialog();
            isgenxin = true;
        }
        //������Ԫ�ذ�ť����Ƶ���¼�����myAddItemForm1����
        private void tsbadditem_Click(object sender, EventArgs e)
        {
            AddItemForm1 myAddItemForm1 = new AddItemForm1();
            myAddItemForm1.ShowDialog();
            isgenxin = true;
        }
        //�����˵����е�����Ԫ�ذ�ť���¼�����myAddItemForm1����
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm1 myAddItemForm1 = new AddItemForm1();
            myAddItemForm1.ShowDialog();
            isgenxin = true;
        }

        //����޸�Ƶ����ť�������¼�
        private void tsbupdate_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //����˵������޸�Ƶ���������¼�
        private void �޸�Ƶ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //����޸�Ԫ�ذ�ť�������¼�
        private void tsbupdateitem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //����˵������޸�Ԫ�ش������¼�
        private void �޸�Ԫ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }

        //����˵�����ɾ��Ƶ���������¼�
        private void ɾ��Ƶ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //���ɾ��Ƶ����ť�������¼�
        private void tsbdelete_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //���ɾ��Ԫ�ذ�ť�������¼�
        private void tsbdeleteitem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //����˵�����ɾ��Ԫ�ش������¼�
        private void ɾ��Ԫ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //����˵���������Ƶ���������¼�
        private void ����Ƶ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm mySelectForm = new SelectForm();
            mySelectForm.ShowDialog();
            isgenxin = true;
        }
        //��������洢��ť�������¼�
        private void tsbselect_Click(object sender, EventArgs e)
        {
            SelectForm mySelectForm = new SelectForm();
            mySelectForm.ShowDialog();
            isgenxin = true;
        }
        //�����ҳ�������¼�
        private void tsbhomepaper_Click(object sender, EventArgs e)
        {
            OpenPage(Properties.Settings.Default.uri);
            cbxaddress.Text = Properties.Settings.Default.uri;
        }

        //����˵�������ʾƵ����������ť�����¼�
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem2.Text == "����ʾƵ��������")
            {
                tspchannel.Visible = false;
                toolStripMenuItem2.Text = "��ʾƵ��������";
            }
            else
            {
                tspchannel.Visible = true;
                toolStripMenuItem2.Text = "����ʾƵ��������";
            }
        }
        //����˵�������ʾ��վ��������ť�������¼�
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem3.Text == "����ʾ��վ������")
            {
                tspweb.Visible = false;
                toolStripMenuItem3.Text = "��ʾ��վ������";
            }
            else
            {
                tspweb.Visible = true;
                toolStripMenuItem3.Text = "����ʾ��վ������";
            }
        }

        //�����û�ѡ��Ľڵ����ҳ�ķ���
        private void SelectTreeNode(TreeNode node)
        {
            if (node.Tag != null&&node.ImageIndex==1)
            {
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
                cbxaddress.Text = (string)node.Tag;
                TabPage page = new TabPage(node.Text);
                WebBrowser web = new WebBrowser();
                web.Url = new Uri((string)node.Tag);
                web.Dock = DockStyle.Fill;
                selectweb = web;
                page.Controls.Add(web);
                tclweb.TabPages.Add(page);
                tclweb.SelectedTab = page;
                tsbback.Enabled = true;
                tsbgo.Enabled = true;
                tsbrenovate.Enabled = true;
            }
        }
        //�ر���ҳ�ķ���
        private void ClosePage(bool Isleft)
        {
          if (Isleft)
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        if (n.Text == tclweb.SelectedTab.Text)
                        {
                            n.ImageIndex = 1;
                            n.SelectedImageIndex = 1;
                        }
                    }
                }
                tclweb.TabPages.Remove(tclweb.SelectedTab);
            }
        }

        //��ʾ����Ƶ��������
        private void ShowForm()
        {
            IRssLink myIRssLink=ReadRssLinkFactory.ReadRssLink();
            readRssLinks = myIRssLink.ReadRssLink();
            if (readRssLinks == null)
            {
                this.Close();
            }
            else
            {
                foreach (ReadRssLinks r in readRssLinks)
                {
                    if (r.Defaultshow)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = r.Title;
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                        try
                        {
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
                        catch
                        {
                            if (MessageBox.Show(r.Title + "�ļ�·���Ըı䣬�Ƿ�ɾ����Ƶ��", "·������", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                XmlDocument xmld = new XmlDocument();
                                xmld.Load("RssLinks.xml");
                                XmlNode linknode = xmld.SelectSingleNode("links");
                                XmlNodeList xmllist = linknode.SelectNodes("link");
                                foreach (XmlNode n in xmllist)
                                {
                                    if (r.Title == n.SelectSingleNode("title").InnerText && r.Uri == n.SelectSingleNode("uri").InnerText)
                                    {
                                        linknode.RemoveChild(n);
                                    }
                                }
                                xmld.Save("RssLinks.xml");
                            }

                        }
                    }
                }

            }
        }
        //����ҳ�ķ���
        private void OpenPage(string dizhi)
        {
            if (dizhi.Length!=0)
            {
                TabPage page = new TabPage();
                WebBrowser web = new WebBrowser();
                try
                {

                    web.Url = new Uri(dizhi);
                    web.Dock = DockStyle.Fill;
                    selectweb = web;
                    page.Controls.Add(web);
                    tclweb.TabPages.Add(page);
                    tclweb.SelectedTab = page;
                    tsbback.Enabled = true;
                    tsbgo.Enabled = true;
                    tsbrenovate.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("��������ȷ����ַ��", "��ַ����", MessageBoxButtons.OK);
                }
            }
        }
        //��ȡ��ǰѡ�����ҳ
        private void tclweb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           selectweb = (WebBrowser)tclweb.TabPages[tclweb.SelectedIndex].Controls[0];
              
        }
        //������ť�������¼�
        private void tsbback_Click(object sender, EventArgs e)
        {
            selectweb.GoBack();
        }
        //�����ǰ��ť�������¼�
        private void tsbgo_Click(object sender, EventArgs e)
        {
            selectweb.GoForward();
        }
        //����˵����е�������ҳ��ť�������¼�
        private void ������ҳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShenZhiForm myShenZhiForm = new ShenZhiForm();
            myShenZhiForm.ShowDialog();
        }     
    }
}