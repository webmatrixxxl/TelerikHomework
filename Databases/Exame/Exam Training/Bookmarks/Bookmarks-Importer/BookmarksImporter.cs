using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;
using Bookmarks.Model;

namespace Bookmarks_Importer
{
    public static class BookmarksImporter
    {
        static void Main()
        {
            TransactionScope tran = new TransactionScope();

            using (tran)
            {


                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("../../bookmarks.xml");
                string xPathQuery = "/bookmarks/bookmark";

                XmlNodeList bookmarksList = xmlDoc.SelectNodes(xPathQuery);
                foreach (XmlNode bookmarkNode in bookmarksList)
                {
                    string username = bookmarkNode.GetChildText("username");
                    string title = bookmarkNode.GetChildText("title");
                    string url = bookmarkNode.GetChildText("url");
                    string notes = bookmarkNode.GetChildText("notes");
                    string name = bookmarkNode.GetChildText("name");
                    string password = bookmarkNode.GetChildText("password");
                    string allTags = bookmarkNode.GetChildText("tags");

                    string[] tags = { };

                    if (allTags != null)
                    {
                        tags = allTags.Split(',');

                        for (int i = 0; i < tags.Length; i++)
                        {
                            tags[i] = tags[i].Trim();
                        }
                    }

                    BookmarksDAL.AddBookmark(username, title, url, tags, notes, name, password);

                }
            }

            tran.Complete();
        }

        public static string GetChildText(this XmlNode node, string tagName)
        {
            XmlNode childNode = node.SelectSingleNode(tagName);

            if (childNode == null)
            {
                return null;
            }

            return childNode.InnerText.Trim();
        }
    }
}
