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
        //定义一个泛型List<ReadRssLinks>记录频道
        private List<ReadRssLinks> readRssLinks;

        internal List<ReadRssLinks> ReadRssLinks
        {
            get { return readRssLinks; }
            set { readRssLinks = value; }
        }
        //定义一个类RssChannel的实例rssChannel记录频道具体信息
        private RssChannel rssChannel;
  
        public Form1()
        {
            InitializeComponent();
           
        }
        //定义字段isgenxin记录是否更新
        private bool isgenxin;
        //定义字段selectweb记录选择的网页
        private WebBrowser selectweb;
        //定义字段uri记录主页的网址
       
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
        //每次加载主页面时触发的事件
        private void Form1_Load(object sender, EventArgs e) 
        {
            this.Text = "RSS阅读器";
            ShowForm();
        }
        //用户双击节点时触发事件将打开选中的节点的网址事件
         private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
             SelectTreeNode(e.Node);
             tsbopen.Enabled = false;
        }
        //用户只有左键双击网页才会关闭
        private void tclweb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClosePage(e.Button == MouseButtons.Left);
        }
        //打开在cbxaddress中的网页事件
        private void butgoto_Click(object sender, EventArgs e)
        {
            OpenPage(cbxaddress.Text);
        }
        //点击保存方式按钮触发的事件，打开ShowRssForm窗口
        private void tsbchangesave_Click(object sender, EventArgs e)
        {
            ShowRssForm myShowRssForm = new ShowRssForm();
            myShowRssForm.ShowDialog();
        }
        //点击频道存储按钮触发的事件，打开ShowRssForm窗口
        private void 频道存储ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowRssForm myShowRssForm = new ShowRssForm();
            myShowRssForm.ShowDialog();

        }
        //网页刷新的事件
        private void tsbrenovate_Click(object sender, EventArgs e)
        {
            OpenPage(cbxaddress.Text);
        }
        //切到全屏显示网页事件
        private void tsbfull_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            tsbreturn.Visible = true;
            tsbfull.Visible = false;
        }
        //菜单栏中点击全屏或恢复按钮触发的事件
        private void 显示频道工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
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
        //恢复频道和网页共存样式事件
        private void tsbreturn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            tsbreturn.Visible = false;
            tsbfull.Visible = true;
        }
        //单击节点时启用打开按钮事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.ImageIndex == 1)
            {
                tsbopen.Enabled = true;
                tsbopen.Tag = e.Node;
            }
        }
        //单击打开按钮打开频道事件
        private void tsbopen_Click(object sender, EventArgs e)
        {
            SelectTreeNode((TreeNode)tsbopen.Tag);
            tsbopen.Enabled = false;
        }
        //单击菜单栏中的增加频道按钮的事件，打开mySaveForm窗口
        private void 增加频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm mySaveForm = new SaveForm();
            mySaveForm.ShowDialog();
            isgenxin = true;
        }
        //点击添加频道按钮增加频道事件，打开mySaveForm窗口
        private void tsbaddpindao_Click(object sender, EventArgs e)
        {
            SaveForm mySaveForm = new SaveForm();
            mySaveForm.ShowDialog();
            isgenxin = true;
        }
        //点击添加元素按钮增加频道事件，打开myAddItemForm1窗口
        private void tsbadditem_Click(object sender, EventArgs e)
        {
            AddItemForm1 myAddItemForm1 = new AddItemForm1();
            myAddItemForm1.ShowDialog();
            isgenxin = true;
        }
        //单击菜单栏中的增加元素按钮的事件，打开myAddItemForm1窗口
        private void 添加新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm1 myAddItemForm1 = new AddItemForm1();
            myAddItemForm1.ShowDialog();
            isgenxin = true;
        }

        //点击修改频道按钮触发的事件
        private void tsbupdate_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击菜单栏中修改频道触发的事件
        private void 修改频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击修改元素按钮触发的事件
        private void tsbupdateitem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击菜单栏中修改元素触发的事件
        private void 修改元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = true;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }

        //点击菜单栏中删除频道触发的事件
        private void 删除频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击删除频道按钮触发的事件
        private void tsbdelete_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击删除元素按钮触发的事件
        private void tsbdeleteitem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击菜单栏中删除元素触发的事件
        private void 删除元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm1 myUpdateForm1 = new UpdateForm1();
            myUpdateForm1.IsUpdateorDelete = false;
            myUpdateForm1.ShowDialog();
            isgenxin = true;
        }
        //点击菜单栏中搜索频道触发的事件
        private void 搜索频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm mySelectForm = new SelectForm();
            mySelectForm.ShowDialog();
            isgenxin = true;
        }
        //点击搜索存储按钮触发的事件
        private void tsbselect_Click(object sender, EventArgs e)
        {
            SelectForm mySelectForm = new SelectForm();
            mySelectForm.ShowDialog();
            isgenxin = true;
        }
        //点击主页触发的事件
        private void tsbhomepaper_Click(object sender, EventArgs e)
        {
            OpenPage(Properties.Settings.Default.uri);
            cbxaddress.Text = Properties.Settings.Default.uri;
        }

        //点击菜单栏中显示频道工具栏按钮触发事件
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem2.Text == "√显示频道工具栏")
            {
                tspchannel.Visible = false;
                toolStripMenuItem2.Text = "显示频道工具栏";
            }
            else
            {
                tspchannel.Visible = true;
                toolStripMenuItem2.Text = "√显示频道工具栏";
            }
        }
        //点击菜单栏中显示网站工具栏按钮触发的事件
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem3.Text == "√显示网站工具栏")
            {
                tspweb.Visible = false;
                toolStripMenuItem3.Text = "显示网站工具栏";
            }
            else
            {
                tspweb.Visible = true;
                toolStripMenuItem3.Text = "√显示网站工具栏";
            }
        }

        //根据用户选择的节点打开网页的方法
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
        //关闭网页的方法
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

        //显示所有频道的内容
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
                            if (MessageBox.Show(r.Title + "文件路径以改变，是否删除此频道", "路径错误", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
        //打开网页的方法
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
                    MessageBox.Show("请输入正确的网址！", "网址错误", MessageBoxButtons.OK);
                }
            }
        }
        //获取当前选择的网页
        private void tclweb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           selectweb = (WebBrowser)tclweb.TabPages[tclweb.SelectedIndex].Controls[0];
              
        }
        //点击向后按钮触发的事件
        private void tsbback_Click(object sender, EventArgs e)
        {
            selectweb.GoBack();
        }
        //点击向前按钮触发的事件
        private void tsbgo_Click(object sender, EventArgs e)
        {
            selectweb.GoForward();
        }
        //点击菜单栏中的设置主页按钮触发的事件
        private void 设置主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShenZhiForm myShenZhiForm = new ShenZhiForm();
            myShenZhiForm.ShowDialog();
        }     
    }
}