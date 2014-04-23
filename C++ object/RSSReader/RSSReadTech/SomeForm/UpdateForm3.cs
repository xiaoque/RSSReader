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
        //���ֶ�oldname��¼ѡ��Ľڵ�
        private string oldname;

        public string Oldname
        {
            get { return oldname; }
            set { oldname = value; }
        }
        //���ֶ�fathername��¼ѡ���ֶεĸ��ڵ�
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
        //����txbname��txbaddres�Ƿ�Ϊ�����ж��Ƿ�����btnok
        private void txbname_TextChanged(object sender, EventArgs e)
        {
            if(txbname.Text.Length!=0&&txbaddress.Text.Length!=0)
            {
                btnok.Enabled = true;
            }
        }
        //����txbname��txbaddres�Ƿ�Ϊ�����ж��Ƿ�����btnok
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
                MessageBox.Show("�޸ĳɹ�", "�ɹ�", MessageBoxButtons.OK);
                Close();

            }
            catch
            {
                MessageBox.Show("��������ȷ����ַ��", "��ַ����", MessageBoxButtons.OK);
            }
           
        }

        private void UpdateForm3_Load(object sender, EventArgs e)
        {
            this.Text = "�޸�Ԫ��";
            txbname.Text = oldname;
            txbaddress.Text = oldlink;
        }
    }
}