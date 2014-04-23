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
        //�ֶ�isShow����¼�û��ǵ������һ������ȡ��
        private bool isShow;
        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }
        //�ֶ�uri��¼�û�ѡ���·��
        private string uri;

        public string Uri
        {
            get { return uri; }
            set { uri = value; }
        }
        //�ֶμ�¼�Ƿ���ʾ��һ����ť
        private bool isShowbackbtn;

        public bool IsShowbackbtn
        {
            get { return isShowbackbtn; }
            set { isShowbackbtn = value; }
        }

        //�ֶ�ReadRssLinks��¼Ҫ��ӵ�Ƶ��
        private ReadRssLinks readRssLinks;
        public AddForm()
        {
            InitializeComponent();
        }
        //ҳ�����ʱ�����¼�
        private void AddForm_Load(object sender, EventArgs e)
        {
            this.Text = "���Ƶ��";
            if (!isShowbackbtn)
            {
                btnold.Visible = true;
            }
            else
            {
                btnold.Visible = false;
            }
        }
        //������Ӱ�ť��������¼�
        private void btnadd_Click(object sender, EventArgs e)
        {
            readRssLinks = new ReadRssLinks( txbname.Text,this.uri,ckbdefaultshow.Checked);
            IRssLink myIRssLink=ReadRssLinkFactory.ReadRssLink();
            if (myIRssLink.Judge(readRssLinks))
            {
                MessageBox.Show("Ƶ���Ѵ���", "Ƶ���ظ�", MessageBoxButtons.OK);
            }
            else
            {
                myIRssLink.AddChannel(readRssLinks);
                MessageBox.Show("��ӳɹ�", "�ɹ�", MessageBoxButtons.OK);
                this.isShow = false;
                this.Close();
            }
        }
        //������һ���������ص�SavaForm���ڵ��¼�
        private void btnold_Click(object sender, EventArgs e)
        {
            this.isShow = true;
            this.Hide();
            
        }
        //�ж�txbname�Ƿ�Ϊ�գ���Ϊ����Ӱ�ť������
        private void txbname_TextChanged(object sender, EventArgs e)
        {
            if (txbname.Text.Length != 0)
            {
                btnadd.Enabled = true;
            }
        }
        //���ȡ����ť�����¼�
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.isShow = false;
            this.Close();
        }

        
    }
}