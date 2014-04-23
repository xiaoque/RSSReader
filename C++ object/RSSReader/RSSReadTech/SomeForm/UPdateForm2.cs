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
    public partial class UPdateForm2 : Form
    {
        private string oldname;

        public string Oldname
        {
            get { return oldname; }
            set { oldname = value; }
        }

       

        public UPdateForm2()
        {
            InitializeComponent();
        }
        private void UPdateForm2_Load(object sender, EventArgs e)
        {
            this.Text = "修改频道";
            txbname.Text = this.oldname;
        }

        //点击确定按钮触发修改频道的事件
        private void btnok_Click(object sender, EventArgs e)
        {
            BtnOkChannel();

        }
        //点击取消按钮关闭窗口
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //判断txbaddress的内容是否为空，不为空将启用按钮btnok
        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            if(txbaddress.Text.Length!=0)
            {
                btnok.Enabled = true;
            }
        }
        //单击浏览按钮打开openFileDialog1控件的事件
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbaddress.Text = openFileDialog1.FileName;
            }
        }
        //方法BtnOk先检验修改后的路径是否正确，正确执行修改工作
        private void BtnOkChannel()
        {
            try
            {
                RssChannel myRssChannel = new RssChannel(txbaddress.Text);
                ReadRssLinks readRssLinks = new ReadRssLinks(txbname.Text, txbaddress.Text,checkBox1.Checked);
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.UpdateChannel(oldname,readRssLinks);
                MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                Close();
                                 
            }
            catch
            {
                MessageBox.Show("请输入正确的路径！", "文件错误", MessageBoxButtons.OK);
            }
        }

       

       
        

        
    }
}