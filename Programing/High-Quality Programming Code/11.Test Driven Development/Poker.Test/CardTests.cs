using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string expected = "A♠";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTenDiamond()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);
            string expected = "10♦";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringSevenDiamond()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Clubs);
            string expected = "7♣";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTwoDiamond()
        {
            Card card = new Card(CardFace.Two, CardSuit.Hearts);
            string expected = "2♥";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringJackDiamond()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Diamonds);
            string expected = "J♦";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
