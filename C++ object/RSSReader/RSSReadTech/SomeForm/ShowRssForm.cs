using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RSSReadTech.DBdata;
using RSSReadTech.Work;
using RSSReadTech.Rss;


namespace RSSReadTech.SomeForm
{
    public partial class ShowRssForm : Form
    {
        private bool isSaveXml;
        public ShowRssForm()
        {
            InitializeComponent();
        }
        //ҳ�����ʱ���������������ж�ʹ�����ַ����������ݵĶ�ȡ
        private void ShowRssForm_Load(object sender, EventArgs e)
        {
            this.Text = "�洢��ʽ";
            IRssLink myIRssLink=ReadRssLinkFactory.ReadRssLink();
            DataSet ds = myIRssLink.GetRssLink();
            dataGridView1.DataSource = ds.Tables[0];
            if (Properties.Settings.Default.Saverss == "xml")
            {
                rdbxml.Checked = true;
                isSaveXml = true;
            }
            else
            {
                rdbDb.Checked = true;
                isSaveXml = false;
            }
                
        }
        //���ȷ����ť�޸Ĵ洢��ʽ
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!isSaveXml)
            {
                if (rdbxml.Checked)
                {
                    Properties.Settings.Default.Saverss = "xml";
                    Properties.Settings.Default.Save();
                    DB mybd = new DB();
                    DataSet ds= mybd.SwitchDatatoXml();
                    ReadRssLinkXml myReadRssLinkXml = new ReadRssLinkXml();
                    for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
                    {
                        ReadRssLinks readRssLinks = new ReadRssLinks(ds.Tables[0].Rows[n][0].ToString(), ds.Tables[0].Rows[n][1].ToString(), (bool)ds.Tables[0].Rows[n][2]);
                        myReadRssLinkXml.AddChannel(readRssLinks);
                    }

                }
            }
            if (isSaveXml)
            {
                if (rdbDb.Checked)
                {
                    Properties.Settings.Default.Saverss = "db";
                    Properties.Settings.Default.Save();
                    DB mybd = new DB();
                    XmlDocument xmld = new XmlDocument();
                    xmld.Load("RssLinks.xml");
                    XmlNode node = xmld.SelectSingleNode("links");
                    XmlNodeList xmllist = node.SelectNodes("link");
                    foreach (XmlNode n in xmllist)
                    {
                        ReadRssLinks r = new ReadRssLinks(n.SelectSingleNode("title").InnerText, n.SelectSingleNode("uri").InnerText, n.SelectSingleNode("defaultshow").InnerText == "true" ? true : false);
                        try
                        {
                            mybd.SwitchXmltoData(r);
                            node.RemoveChild(n);
                        }
                        catch
                        {
                            MessageBox.Show("���ݿ�û����", "���ݿ�", MessageBoxButtons.OK);
                            Properties.Settings.Default.Saverss = "xml";
                            Properties.Settings.Default.Save();
                        }
                        
                    }
                    xmld.Save("RssLinks.xml");
                }
            }
            Close();
        }
        //���ȡ����ť�����رմ��ڵ��¼�
        private void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}