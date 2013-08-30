using QueringForArticles.Model;
using System.Collections.Generic;

namespace QueringForArticles
{
    public class RootObject
    {
        public List<Article> articles { get; set; }
        public string description { get; set; }
        public string syndication_url { get; set; }
        public string title { get; set; }
    }
}
