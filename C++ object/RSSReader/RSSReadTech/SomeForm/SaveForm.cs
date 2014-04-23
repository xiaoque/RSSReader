using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RSSReadTech.Rss;

namespace RSSReadTech.SomeForm
{
    public partial class SaveForm : Form
    {
        
        //字段isShow来记录用户是点击下一步还是取消
        private bool isShow;

        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }
        private AddForm myAddForm = new AddForm();
        public SaveForm()
        {
            InitializeComponent();
        }
        //单击浏览按钮打开openFileDialog1控件的事件
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxaddress.Text = openFileDialog1.FileName;
            }
        }
        //单击下一步按钮查看是否选中ckbvalidate控件，来判断是否进行路径判断事件
        private void btnnext_Click(object sender, EventArgs e)
        {
            BtnNext();

        }
        //单击取消按钮的事件
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.isShow = false;
            this.Close();
            myAddForm.Close();
        }
        //方法BtnNext是对用户按下一步时的操作
        private void BtnNext()
        {
            try
            {
                RssChannel myRssChannel = new RssChannel(tbxaddress.Text);
                myAddForm.Uri = tbxaddress.Text;
                if (!myAddForm.IsShow)
                {
                    this.Hide();
                    this.isShow = true;
                    myAddForm.ShowDialog();
                    if (myAddForm.IsShow)
                    {
                        this.Visible = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    myAddForm.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的路径或正确的RSS文件！", "文件错误", MessageBoxButtons.OK);
            }
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            this.Text = "添加频道";
        }

    }
}