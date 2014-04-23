using System;
using System.Collections.Generic;
using System.Text;

namespace RSSReadTech.Work
{
    class ReadRssLinkFactory
    {    
        public static IRssLink ReadRssLink()
        {
            IRssLink readRssLink=null;
            string saverss=Properties.Settings.Default.Saverss;

            switch (saverss)
            {
                case "xml":
                    readRssLink = new ReadRssLinkXml();
                    break;
                case "db":
                    readRssLink = new ReadRssLinkDb();
                    break;
                  
            }
            return readRssLink;
        }
    }
}
