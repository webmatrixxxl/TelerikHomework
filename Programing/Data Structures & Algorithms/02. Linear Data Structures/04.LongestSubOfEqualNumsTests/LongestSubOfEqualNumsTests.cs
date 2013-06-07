using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _04.LongestSubOfEqualNumbers;

namespace _04.LongestSubOfEqualNumsTests
{
    [TestClass]
    public class LongestSubOfEqualNumsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            List<int> actual = LongestSubOfEqualNums.FindLongestSubSequenceOfEquals(list);
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(3);
            expected.Add(3);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            List<int> actual = LongestSubOfEqualNums.FindLongestSubSequenceOfEquals(list);
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(2);
            expected.Add(2);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            List<int> actual = LongestSubOfEqualNums.FindLongestSubSequenceOfEquals(list);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            List<int> actual = LongestSubOfEqualNums.FindLongestSubSequenceOfEquals(list);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(1);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(2);
            List<int> actual = LongestSubOfEqualNums.FindLongestSubSequenceOfEquals(list);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(1);

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}