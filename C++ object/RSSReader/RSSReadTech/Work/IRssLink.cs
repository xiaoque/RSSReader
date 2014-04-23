using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RSSReadTech.Rss;

namespace RSSReadTech.Work
{
    interface IRssLink
    {
        List<ReadRssLinks> ReadRssLink();
        DataSet GetRssLink();
        void AddChannel(ReadRssLinks readRssLinks);
        void AddItem(string fathernam,string title,string link);
        void UpdateChannel(string oldname,ReadRssLinks readRssLinks);
        void UpdateItem(string fathername,string oldname,string odllink, string title, string link);
        void DeleteChannel(string Channelname);
        void DeleteItem(string fathername,string title, string link);
        bool Judge(ReadRssLinks readRssLinks);

    }
}
