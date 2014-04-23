using System;
using System.Xml;


namespace RSSReadTech.Rss
{
    /// <summary>
    /// 表示 RSS 2.0 XML 文档中的 Item 元素。
    /// 一个 RssChannel 中包含零个或多个 RssItem。
    /// </summary>
    public class RssItem
    {
        private readonly string title;
        private readonly string description;
        private readonly string link;

        public string Title { get { return title; } }
        public string Description { get { return description; } }
        public string Link { get { return link; } }


        /// <summary>
        /// 根据表示 RSS 2.0 XML 文档内的一个 Item 元素的 XmlNode 生成一个 RSSItem。
        /// </summary>
        /// <param name="itemNode"></param>
        internal RssItem(XmlNode itemNode)
        {
            XmlNode selected;
            selected = itemNode.SelectSingleNode("title");
            if (selected != null)
                title = selected.InnerText;

            selected = itemNode.SelectSingleNode("description");
            if (selected != null)
                description = selected.InnerText;

            selected = itemNode.SelectSingleNode("link");
            if (selected != null)
                link = selected.InnerText;
        }
    }
}