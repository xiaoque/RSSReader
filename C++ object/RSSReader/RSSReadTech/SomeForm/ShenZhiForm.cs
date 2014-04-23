using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReadTech.SomeForm
{
    public partial class ShenZhiForm : Form
    {
       
        public ShenZhiForm()
        {
            InitializeComponent();
        }
        //点击确定按钮触发事件
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebBrowser web = new WebBrowser();
                web.Url = new Uri(textBox1.Text);
                Properties.Settings.Default.uri = textBox1.Text;
                Properties.Settings.Default.Save();
                Close();
            }
            catch
            {
                MessageBox.Show("请输入正确的网址！", "网址错误", MessageBoxButtons.OK);
            }
        }
        //判断textBox1中内容是否为空来判断按钮button1是否可用
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                button1.Enabled = true;
            }
        }
        //点击取消按钮触发的事件
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShenZhiForm_Load(object sender, EventArgs e)
        {
            this.Text = "设置主页";
        }
    }
}