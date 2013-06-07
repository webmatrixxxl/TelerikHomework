using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeContent;
using System.Linq;

namespace FreeContentCatalogTests
{
    [TestClass]
    public class UnitTestICatalog
    {
        [TestMethod]
        public void TestMethod1()
        {
            Catalog catalog = new Catalog();
            ContentItem item = new ContentItem(ContentItemType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(item);

            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), item);

        }
    }
}
