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
        //����ҳ��ʱ��cbxfathername�ؼ���������
        private void AddItemForm1_Load(object sender, EventArgs e)
        {
            this.Text = "���Ԫ��";
            IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
            DataSet ds = myIRssLink.GetRssLink();
            cbxfathername.DataSource = ds.Tables[0];
            cbxfathername.ValueMember = ds.Tables[0].Columns[0].ToString();
            cbxfathername.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }
        //�ж�txbitemname�����ݺ�txbitemname�������Ƿ�Ϊ�գ���Ϊ�ս����ð�ťbtnadd
        private void txbitemname_TextChanged(object sender, EventArgs e)
        {
            if(txbitemname.Text.Length!=0&&txbitemaddress.Text.Length!=0)
            {
                btnadd.Enabled = true;
            }
        }
        //�ж�txbitemname�����ݺ�txbitemname�������Ƿ�Ϊ�գ���Ϊ�ս����ð�ťbtnadd
        private void txbitemaddress_TextChanged(object sender, EventArgs e)
        {
            if (txbitemname.Text.Length != 0 && txbitemaddress.Text.Length != 0)
            {
                btnadd.Enabled = true;
            }
        }
        //���ȡ����ť�����رմ��ڵ��¼�
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //�����Ӱ�ť��������¼�
        private void btnadd_Click(object sender, EventArgs e)
        {

            WebBrowser myWebBrowser = new WebBrowser();
            try
            {
                myWebBrowser.Url = new Uri(txbitemaddress.Text);
                IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                myIRssLink.AddItem(cbxfathername.SelectedValue.ToString(), txbitemname.Text, txbitemaddress.Text);
                MessageBox.Show("��ӳɹ�", "�ɹ�", MessageBoxButtons.OK);
                Close();

            }
            catch
            {
                MessageBox.Show("��������ȷ����ַ��", "��ַ����", MessageBoxButtons.OK);
            }
        }
    }
}