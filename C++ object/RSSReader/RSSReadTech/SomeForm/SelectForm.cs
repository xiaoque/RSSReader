using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RSSReadTech.Rss;

namespace RSSReadTech.SomeForm
{
    public partial class SelectForm : Form
    {
        private TreeNode selectNode;
        public SelectForm()
        {
            InitializeComponent();
        }

        //���������ť��openFileDialog1�ؼ����¼�
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txbaddress.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //�����ѯ��ť�������¼�
        private void bntselect_Click(object sender, EventArgs e)
        {
            SelectXml(txbaddress.Text);
        }
        //����txbaddress�Ƿ��������жϲ�ѯ��ť�Ƿ�����
        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            if (txbaddress.Text.Length != 0)
            {
                bntselect.Enabled = true;
            }
        }
        //���ȡ����ť�������¼�
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //�û�ѡ��ڵ㴥���¼�
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectNode = e.Node;
            btnadd.Enabled = true;
        }
        //�����Ӱ�ť�������¼�
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                RssChannel myRssChannel = new RssChannel(selectNode.Tag.ToString());
                AddForm myAddForm = new AddForm();
                myAddForm.IsShowbackbtn = true;
                myAddForm.Uri = selectNode.Tag.ToString();
                myAddForm.ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("RSS�ļ���ʽ����ȷ��", "�ļ�����", MessageBoxButtons.OK);
            }
        }
        //��ѯѡ��Ŀ¼�µ�XML�ļ�
        private void SelectXml(string mulu)
        {
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(mulu);
            FileInfo[] files = myDirectoryInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                if (IsXml(f.Name))
                {
                    TreeNode node = new TreeNode(f.Name);
                    node.Tag = f.FullName;
                    treeView1.Nodes.Add(node);
                }
            }
        }
        //�ж��ļ��Ƿ�Ϊxml�ļ�
        private bool IsXml(string name)
        {
            bool isXml = false;
            if (name.Substring(name.Length - 3) == "xml")
            {
                isXml = true;
            }

            return isXml;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.Text = "����RSS�ļ�";
        }

       

       
    }
}