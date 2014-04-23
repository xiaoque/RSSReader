using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using RSSReadTech.Rss;
using System.Windows.Forms;
namespace RSSReadTech.DBdata
{
    class DB
    {
        private string str;
        public DB()
        {
            str = Properties.Settings.Default.str;
        }
        //�����ݴ������ݿ�
        public void SwitchXmltoData(ReadRssLinks readRssLinks)
        {

            SqlConnection sc = new SqlConnection(str);
            SqlCommand cd = new SqlCommand();
            cd.Connection = sc;
            cd.CommandText = "SwitchXmltoData";
            cd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp1 = cd.Parameters.Add("@title", SqlDbType.VarChar, 100);
            sp1.Value = readRssLinks.Title;
            SqlParameter sp2 = cd.Parameters.Add("@uri", SqlDbType.VarChar, 200);
            sp2.Value = readRssLinks.Uri;
            SqlParameter sp3 = cd.Parameters.Add("@defaultshow", SqlDbType.Bit);
            sp3.Value = readRssLinks.Defaultshow;
            SqlDataAdapter da = new SqlDataAdapter(cd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ReadRss");
                
        }
        //�����ݿ��в鴦�������ݲ�������ݿ�
        public DataSet SwitchDatatoXml()
        {
            SqlConnection sc=new SqlConnection(str);
            SqlCommand cd=new SqlCommand();
            cd.Connection=sc;
            cd.CommandText="SwitchDatatoXml";
            cd.CommandType=CommandType.StoredProcedure;
            SqlDataAdapter da=new SqlDataAdapter(cd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ReadRss");
            return ds;

        }
        //���ݿ��ѯ����Ƶ��
        public DataSet SelectXml()
        {
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cd = new SqlCommand();
            cd.Connection = sc;
            cd.CommandText = "SelectXml";
            cd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ReadRss");
            return ds;
        }
        //���ݿ��޸�Ƶ��
        public void UpdateChannel(string oldname, ReadRssLinks readRssLinks)
        {
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cd = new SqlCommand();
            cd.Connection = sc;
            cd.CommandText = "UpdateChannel";
            cd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = cd.Parameters.Add("@oldtitle", SqlDbType.VarChar, 100);
            sp.Value = oldname;
            SqlParameter sp1 = cd.Parameters.Add("@title", SqlDbType.VarChar, 100);
            sp1.Value = readRssLinks.Title;
            SqlParameter sp2 = cd.Parameters.Add("@uri", SqlDbType.VarChar, 200);
            sp2.Value = readRssLinks.Uri;
            SqlParameter sp3 = cd.Parameters.Add("@defaultshow", SqlDbType.Bit);
            sp3.Value = readRssLinks.Defaultshow;
            SqlDataAdapter da = new SqlDataAdapter(cd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ReadRss");
        }
        public void DeleteChannel(string Channelname)
        {
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cd = new SqlCommand();
            cd.Connection = sc;
            cd.CommandText = "DeleteChannel";
            cd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = cd.Parameters.Add("@Channelname", SqlDbType.VarChar, 100);
            sp.Value = Channelname;
            SqlDataAdapter da = new SqlDataAdapter(cd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ReadRss");
        }
    }
}
