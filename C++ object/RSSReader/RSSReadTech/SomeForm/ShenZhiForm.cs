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
        //���ȷ����ť�����¼�
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
                MessageBox.Show("��������ȷ����ַ��", "��ַ����", MessageBoxButtons.OK);
            }
        }
        //�ж�textBox1�������Ƿ�Ϊ�����жϰ�ťbutton1�Ƿ����
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                button1.Enabled = true;
            }
        }
        //���ȡ����ť�������¼�
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShenZhiForm_Load(object sender, EventArgs e)
        {
            this.Text = "������ҳ";
        }
    }
}