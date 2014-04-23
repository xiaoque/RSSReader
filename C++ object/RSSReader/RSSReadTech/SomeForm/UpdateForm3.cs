using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RSSReadTech.Work;

namespace RSSReadTech.SomeForm
{
    public partial class UpdateForm3 : Form
    {
        //用字段oldname记录选择的节点
        private string oldname;

        public string Oldname
        {
            get { return oldname; }
            set { oldname = value; }
        }
        //用字段fathername记录选择字段的父节点
        private string fathername;

        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }
        private string oldlink;

        public string Oldlink
        {
            get { return oldlink; }
            set { oldlink = value; }
        }

        public UpdateForm3()
        {
            InitializeComponent();
        }
        //根据txbname和txbaddres是否为空来判断是否启用btnok
        private void txbname_TextChanged(object sender, EventArgs e)
        {
            if(txbname.Text.Length!=0&&txbaddress.Text.Length!=0)
            {
                btnok.Enabled = true;
            }
        }
        //根据txbname和txbaddres是否为空来判断是否启用btnok
        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            if (txbname.Text.Length != 0 && txbaddress.Text.Length != 0)
            {
                btnok.Enabled = true;
            }

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            WebBrowser myWebBrowser = new WebBrowser();
            try
            {
                myWebBrowser.Url = new Uri(txbaddress.Text);
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.UpdateItem(this.fathername, this.oldname,this.oldlink,txbname.Text, txbaddress.Text);
                MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                Close();

            }
            catch
            {
                MessageBox.Show("请输入正确的网址！", "网址错误", MessageBoxButtons.OK);
            }
           
        }

        private void UpdateForm3_Load(object sender, EventArgs e)
        {
            this.Text = "修改元素";
            txbname.Text = oldname;
            txbaddress.Text = oldlink;
        }
    }
}