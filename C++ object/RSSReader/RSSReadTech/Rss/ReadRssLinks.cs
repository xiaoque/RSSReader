using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RSSReadTech.Rss
{
    class ReadRssLinks
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string uri;

        public string Uri
        {
            get { return uri; }
            set { uri = value; }
        }
        private bool defaultshow;

        public bool Defaultshow
        {
            get { return defaultshow; }
            set { defaultshow = value; }
        }
        public ReadRssLinks(string title, string uri, bool defaultshow)
        {
            this.uri = uri;
            this.title = title;
            this.defaultshow = defaultshow;
        }
    }
}
