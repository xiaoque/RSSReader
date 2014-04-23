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
            this.Text = "�޸�Ƶ��";
            txbname.Text = this.oldname;
        }

        //���ȷ����ť�����޸�Ƶ�����¼�
        private void btnok_Click(object sender, EventArgs e)
        {
            BtnOkChannel();

        }
        //���ȡ����ť�رմ���
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //�ж�txbaddress�������Ƿ�Ϊ�գ���Ϊ�ս����ð�ťbtnok
        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            if(txbaddress.Text.Length!=0)
            {
                btnok.Enabled = true;
            }
        }
        //���������ť��openFileDialog1�ؼ����¼�
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbaddress.Text = openFileDialog1.FileName;
            }
        }
        //����BtnOk�ȼ����޸ĺ��·���Ƿ���ȷ����ȷִ���޸Ĺ���
        private void BtnOkChannel()
        {
            try
            {
                RssChannel myRssChannel = new RssChannel(txbaddress.Text);
                ReadRssLinks readRssLinks = new ReadRssLinks(txbname.Text, txbaddress.Text,checkBox1.Checked);
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.UpdateChannel(oldname,readRssLinks);
                MessageBox.Show("�޸ĳɹ�", "�ɹ�", MessageBoxButtons.OK);
                Close();
                                 
            }
            catch
            {
                MessageBox.Show("��������ȷ��·����", "�ļ�����", MessageBoxButtons.OK);
            }
        }

       

       
        

        
    }
}