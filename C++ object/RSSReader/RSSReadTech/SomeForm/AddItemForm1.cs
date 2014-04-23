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
    public partial class AddItemForm1 : Form
    {
        public AddItemForm1()
        {
            InitializeComponent();
        }
        //加载页面时给cbxfathername控件加载数据
        private void AddItemForm1_Load(object sender, EventArgs e)
        {
            this.Text = "添加元素";
            IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
            DataSet ds = myIRssLink.GetRssLink();
            cbxfathername.DataSource = ds.Tables[0];
            cbxfathername.ValueMember = ds.Tables[0].Columns[0].ToString();
            cbxfathername.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }
        //判断txbitemname的内容和txbitemname的内容是否为空，不为空将启用按钮btnadd
        private void txbitemname_TextChanged(object sender, EventArgs e)
        {
            if(txbitemname.Text.Length!=0&&txbitemaddress.Text.Length!=0)
            {
                btnadd.Enabled = true;
            }
        }
        //判断txbitemname的内容和txbitemname的内容是否为空，不为空将启用按钮btnadd
        private void txbitemaddress_TextChanged(object sender, EventArgs e)
        {
            if (txbitemname.Text.Length != 0 && txbitemaddress.Text.Length != 0)
            {
                btnadd.Enabled = true;
            }
        }
        //点击取消按钮触发关闭窗口的事件
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //点击添加按钮触发添加事件
        private void btnadd_Click(object sender, EventArgs e)
        {

            WebBrowser myWebBrowser = new WebBrowser();
            try
            {
                myWebBrowser.Url = new Uri(txbitemaddress.Text);
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.AddItem(cbxfathername.SelectedValue.ToString(), txbitemname.Text, txbitemaddress.Text);
                MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                Close();

            }
            catch
            {
                MessageBox.Show("请输入正确的网址！", "网址错误", MessageBoxButtons.OK);
            }
        }
    }
}