using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RSSReadTech.Work;
using RSSReadTech.Rss;
namespace RSSReadTech.SomeForm
{
    public partial class AddForm : Form
    {
        //字段isShow来记录用户是点击的上一步还是取消
        private bool isShow;
        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }
        //字段uri记录用户选择的路径
        private string uri;

        public string Uri
        {
            get { return uri; }
            set { uri = value; }
        }
        //字段记录是否显示上一步按钮
        private bool isShowbackbtn;

        public bool IsShowbackbtn
        {
            get { return isShowbackbtn; }
            set { isShowbackbtn = value; }
        }

        //字段ReadRssLinks记录要添加的频道
        private ReadRssLinks readRssLinks;
        public AddForm()
        {
            InitializeComponent();
        }
        //页面加载时触发事件
        private void AddForm_Load(object sender, EventArgs e)
        {
            this.Text = "添加频道";
            if (!isShowbackbtn)
            {
                btnold.Visible = true;
            }
            else
            {
                btnold.Visible = false;
            }
        }
        //单击添加按钮触发添加事件
        private void btnadd_Click(object sender, EventArgs e)
        {
            readRssLinks = new ReadRssLinks( txbname.Text,this.uri,ckbdefaultshow.Checked);
            IRssLink myIRssLink=ReadRssLinkFactory.ReadRssLink();
            if (myIRssLink.Judge(readRssLinks))
            {
                MessageBox.Show("频道已存在", "频道重复", MessageBoxButtons.OK);
            }
            else
            {
                myIRssLink.AddChannel(readRssLinks);
                MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                this.isShow = false;
                this.Close();
            }
        }
        //单击上一步触发返回到SavaForm窗口的事件
        private void btnold_Click(object sender, EventArgs e)
        {
            this.isShow = true;
            this.Hide();
            
        }
        //判断txbname是否为空，若为空添加按钮不可用
        private void txbname_TextChanged(object sender, EventArgs e)
        {
            if (txbname.Text.Length != 0)
            {
                btnadd.Enabled = true;
            }
        }
        //点击取消按钮触发事件
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.isShow = false;
            this.Close();
        }

        
    }
}