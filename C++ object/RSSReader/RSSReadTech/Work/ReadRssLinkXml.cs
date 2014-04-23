using System;
using System.Collections.Generic;
using System.Text;
using RSSReadTech.Rss;
using System.Xml;
using System.Data;

namespace RSSReadTech.Work
{
    class ReadRssLinkXml:IRssLink
    {
    
        #region IRssLink ≥…‘±

        public List<RSSReadTech.Rss.ReadRssLinks>  ReadRssLink()
        {
            string s = System.IO.Directory.GetCurrentDirectory();
            List<ReadRssLinks> list = new List<ReadRssLinks>();
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList xmllist = node.SelectNodes("link");
            foreach (XmlNode n in xmllist)
            {
                ReadRssLinks r = new ReadRssLinks(n.SelectSingleNode("title").InnerText,n.SelectSingleNode("uri").InnerText,n.SelectSingleNode("defaultshow").InnerText == "true" ? true : false);
                
                list.Add(r);
            }
            return list;
        }

        public DataSet  GetRssLink()
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable("ReadLink");
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList xmllist = node.SelectNodes("link");
            DataColumn titleColumn = new DataColumn("title");
            titleColumn.DataType = Type.GetType("System.String");
            DataColumn uriColumn = new DataColumn("uri");
            uriColumn.DataType = Type.GetType("System.String");
            DataColumn defaultshowColumn = new DataColumn("defaultshow");
            defaultshowColumn.DataType = Type.GetType("System.Boolean");
            table.Columns.Add(titleColumn);
            table.Columns.Add(uriColumn);
            table.Columns.Add(defaultshowColumn);
            for (int n = 0; n < xmllist.Count; n++)
            {
                DataRow row = table.NewRow();
                row["title"] = xmllist[n].SelectSingleNode("title").InnerText;
                row["uri"] = xmllist[n].SelectSingleNode("uri").InnerText;
                row["defaultshow"] = xmllist[n].SelectSingleNode("defaultshow").InnerText;
                table.Rows.Add(row);
            }
            ds.Tables.Add(table);
            return ds;

        }

        public void  AddChannel(ReadRssLinks readRssLinks)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlElement xmlLink = xmld.CreateElement("link");
            XmlElement xmlTitle = xmld.CreateElement("title");
            XmlElement xmlUri = xmld.CreateElement("uri");
            XmlElement xmldefaultshow = xmld.CreateElement("defaultshow");

            XmlText xmlTitleText = xmld.CreateTextNode(readRssLinks.Title);
            XmlText xmlUriText = xmld.CreateTextNode(readRssLinks.Uri);
            XmlText xmldefaultshowText = xmld.CreateTextNode(readRssLinks.Defaultshow ? "true" : "false");

            XmlNode title = xmlLink.AppendChild(xmlTitle).AppendChild(xmlTitleText);
            XmlNode uri = xmlLink.AppendChild(xmlUri).AppendChild(xmlUriText);
            XmlNode defaultshow = xmlLink.AppendChild(xmldefaultshow).AppendChild(xmldefaultshowText);
            XmlNode root = xmld.DocumentElement;
            XmlNode link = root.AppendChild(xmlLink);
            xmld.Save("RssLinks.xml");
        }

        public void  AddItem(string fathername,string title, string link)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList nodelist = node.SelectNodes("link");
            foreach (XmlNode n in nodelist)
            {
                if (fathername == n.SelectSingleNode("title").InnerText)
                {
                    XmlDocument xmld1 = new XmlDocument();
                    xmld1.Load(n.SelectSingleNode("uri").InnerText);
                    XmlElement xmlitem = xmld1.CreateElement("item");
                    XmlElement xmlLink = xmld1.CreateElement("link");
                    XmlElement xmlTitle = xmld1.CreateElement("title");
                    XmlText xmlTitleText = xmld1.CreateTextNode(title);
                    XmlText xmlLinkText = xmld1.CreateTextNode(link);
                    XmlNode xtitle = xmlitem.AppendChild(xmlTitle).AppendChild(xmlTitleText);
                    XmlNode xlink = xmlitem.AppendChild(xmlLink).AppendChild(xmlLinkText);
                    XmlNode root = xmld1.DocumentElement;
                    XmlNode channelnode = root.SelectSingleNode("channel");
                    XmlNode item = channelnode.AppendChild(xmlitem);
                    xmld1.Save(n.SelectSingleNode("uri").InnerText);
                }
            }
        }

        public void  UpdateChannel(string oldname,ReadRssLinks readRssLinks)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList nodelist = node.SelectNodes("link");
            foreach(XmlNode n in nodelist)
            {
                if(oldname==n.SelectSingleNode("title").InnerText)
                {
                    n.SelectSingleNode("title").InnerText = readRssLinks.Title;
                    n.SelectSingleNode("uri").InnerText = readRssLinks.Uri;
                    n.SelectSingleNode("defaultshow").InnerText = readRssLinks.Defaultshow?"true":"false";
                    xmld.Save("RssLinks.xml");
                }
            }

        }

        public void  UpdateItem(string fathername,string oldname,string odllink,string title, string link)
        {
 	        XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList nodelist = node.SelectNodes("link");
            foreach (XmlNode n in nodelist)
            {
                if (fathername == n.SelectSingleNode("title").InnerText)
                {
                    XmlDocument xmld1 = new XmlDocument();
                    xmld1.Load(n.SelectSingleNode("uri").InnerText);
                    XmlNode root = xmld1.SelectSingleNode("rss");
                    XmlNode channelroot = root.SelectSingleNode("channel");
                    XmlNodeList itemnode = channelroot.SelectNodes("item");
                    foreach (XmlNode xn in itemnode)
                    {
                        if (oldname == xn.SelectSingleNode("title").InnerText && odllink == xn.SelectSingleNode("link").InnerText)
                        {
                            xn.SelectSingleNode("title").InnerText = title;
                            xn.SelectSingleNode("link").InnerText = link;
                            xmld1.Save(n.SelectSingleNode("uri").InnerText);
                        }
                    }
                }
            }
        }

        public void  DeleteChannel(string Channelname)
        {
 	        XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList nodelist = node.SelectNodes("link");
            foreach (XmlNode n in nodelist)
            {
                if (Channelname == n.SelectSingleNode("title").InnerText)
                {
                    node.RemoveChild(n);
                    xmld.Save("RssLinks.xml");
                }
            }
        }

        public void  DeleteItem(string fathername,string title, string link)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load("RssLinks.xml");
            XmlNode node = xmld.SelectSingleNode("links");
            XmlNodeList nodelist = node.SelectNodes("link");
            foreach (XmlNode n in nodelist)
            {
                if (fathername == n.SelectSingleNode("title").InnerText)
                {
                    XmlDocument xmld1 = new XmlDocument();
                    xmld1.Load(n.SelectSingleNode("uri").InnerText);
                    XmlNode root = xmld1.SelectSingleNode("rss");
                    XmlNode channelroot = root.SelectSingleNode("channel");
                    XmlNodeList itemnode = channelroot.SelectNodes("item");
                    foreach(XmlNode xn in itemnode)
                    {
                        if(title==xn.SelectSingleNode("title").InnerText&&link==xn.SelectSingleNode("link").InnerText)
                        {
                            channelroot.RemoveChild(xn);
                            xmld1.Save(n.SelectSingleNode("uri").InnerText);
                        }
                    }

                }
            }
        }

        public bool  Judge(ReadRssLinks readRssLinks)
        {
            List<ReadRssLinks> readlist=ReadRssLink();   
            bool same=false;
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
