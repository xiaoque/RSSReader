using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using RSSReadTech.Rss;
using RSSReadTech.DBdata;


namespace RSSReadTech.Work
{
    class ReadRssLinkDb:IRssLink
    {
        #region IRssLink 成员

        public List<ReadRssLinks> ReadRssLink()
        {
            List<ReadRssLinks> list = new List<ReadRssLinks>();
            DB mydb = new DB();
            try
            {
                DataSet ds = mydb.SelectXml();
                for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
                {
                    ReadRssLinks readRssLinks = new ReadRssLinks(ds.Tables[0].Rows[n][0].ToString(), ds.Tables[0].Rows[n][1].ToString(), (bool)ds.Tables[0].Rows[n][2]);
                    list.Add(readRssLinks);
                }
                return list;
            }
            catch
            {
                if (MessageBox.Show("数据库没有加载是否选择使用XML文件存储方式", "数据库没加载", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Properties.Settings.Default.Saverss = "xml";
                    Properties.Settings.Default.Save();
                    IRssLink myIRssLink = ReadRssLinkFactory.ReadRssLink();
                    return myIRssLink.ReadRssLink();
                }
                else
                {
                    return null;
                }
            }
        }

        public DataSet GetRssLink()
        {
            DB mydb = new DB();
            DataSet ds = mydb.SelectXml();
            ds = mydb.SelectXml();
            return ds;
        }

        public void AddChannel(ReadRssLinks readRssLinks)
        {
            DB mydb = new DB();
            mydb.SwitchXmltoData(readRssLinks);
        }

        public void AddItem(string fathernam,string title, string link)
        {
            List<ReadRssLinks> list = new List<ReadRssLinks>();
            list=ReadRssLink();
            foreach (ReadRssLinks r in list)
            {
                if (fathernam == r.Title)
                {
                    XmlDocument xmld = new XmlDocument();
                    xmld.Load(r.Uri);
                    XmlElement xmlitem = xmld.CreateElement("item");
                    XmlElement xmlLink = xmld.CreateElement("link");
                    XmlElement xmlTitle = xmld.CreateElement("title");
                    XmlText xmlTitleText = xmld.CreateTextNode(title);
                    XmlText xmlLinkText = xmld.CreateTextNode(link);
                    XmlNode xtitle = xmlitem.AppendChild(xmlTitle).AppendChild(xmlTitleText);
                    XmlNode xlink = xmlitem.AppendChild(xmlLink).AppendChild(xmlLinkText);
                    XmlNode root = xmld.DocumentElement;
                    XmlNode channelnode = root.SelectSingleNode("channel");
                    XmlNode item = channelnode.AppendChild(xmlitem);
                    xmld.Save(r.Uri);
                }
            }

        }

        public void UpdateChannel(string oldname,ReadRssLinks readRssLinks)
        {
            DB mydb = new DB();
            mydb.UpdateChannel(oldname, readRssLinks);
        }

        public void UpdateItem(string fathername,string oldname,string odllink, string title, string link)
        {
            List<ReadRssLinks> list = new List<ReadRssLinks>();
            list = ReadRssLink();
            foreach (ReadRssLinks r in list)
            {
                if (fathername == r.Title)
                {
                    XmlDocument xmld = new XmlDocument();
                    xmld.Load(r.Uri);
                    XmlNode root = xmld.SelectSingleNode("rss");
                    XmlNode channelroot = root.SelectSingleNode("channel");
                    XmlNodeList itemnode = channelroot.SelectNodes("item");
                    foreach (XmlNode xn in itemnode)
                    {
                        if (oldname == xn.SelectSingleNode("title").InnerText && odllink == xn.SelectSingleNode("link").InnerText)
                        {
                            xn.SelectSingleNode("title").InnerText = title;
                            xn.SelectSingleNode("link").InnerText = link;
                            xmld.Save(r.Uri);
                        }
                    }
                }
            }
        }

        public void DeleteChannel(string Channelname)
        {
            DB mydb = new DB();
            mydb.DeleteChannel(Channelname);
        }

        public void DeleteItem(string fathername,string title, string link)
        {

            List<ReadRssLinks> list = new List<ReadRssLinks>();
            list = ReadRssLink();
            foreach (ReadRssLinks r in list)
            {
                if (fathername == r.Title)
                {
                    XmlDocument xmld = new XmlDocument();
                    xmld.Load(r.Uri);
                    XmlNode root = xmld.SelectSingleNode("rss");
                    XmlNode channelroot = root.SelectSingleNode("channel");
                    XmlNodeList itemnode = channelroot.SelectNodes("item");
                    foreach (XmlNode xn in itemnode)
                    {
                        if (title == xn.SelectSingleNode("title").InnerText && link == xn.SelectSingleNode("link").InnerText)
                        {
                            channelroot.RemoveChild(xn);
                            xmld.Save(r.Uri);
                        }
                    }
                }
            }
        }

        public bool Judge(ReadRssLinks readRssLinks)
        {
            
            List<ReadRssLinks> readlist =ReadRssLink();
            bool same = false;
            foreach (ReadRssLinks r in readlist)
            {
                if (r.Uri == readRssLinks.Uri)
                {
                    same = true;
                    break;
                }
            }
            return same;
        }

        #endregion
    }
}
