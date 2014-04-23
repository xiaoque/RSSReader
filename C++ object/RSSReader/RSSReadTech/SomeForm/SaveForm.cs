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
        
        //�ֶ�isShow����¼�û��ǵ����һ������ȡ��
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
        //���������ť��openFileDialog1�ؼ����¼�
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxaddress.Text = openFileDialog1.FileName;
            }
        }
        //������һ����ť�鿴�Ƿ�ѡ��ckbvalidate�ؼ������ж��Ƿ����·���ж��¼�
        private void btnnext_Click(object sender, EventArgs e)
        {
            BtnNext();

        }
        //����ȡ����ť���¼�
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.isShow = false;
            this.Close();
            myAddForm.Close();
        }
        //����BtnNext�Ƕ��û�����һ��ʱ�Ĳ���
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
                MessageBox.Show("��������ȷ��·������ȷ��RSS�ļ���", "�ļ�����", MessageBoxButtons.OK);
            }
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            this.Text = "���Ƶ��";
        }

    }
}