using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void TestHighCard()
        {
            Hand hand = new Hand(
               new Card(CardFace.Jack, CardSuit.Diamonds),
               new Card(CardFace.Queen, CardSuit.Hearts),
               new Card(CardFace.Four, CardSuit.Spades),
               new Card(CardFace.Seven, CardSuit.Clubs),
               new Card(CardFace.Ace, CardSuit.Spades)
           );
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsValidHand()
        {
            Hand hand = new Hand(
               new Card(CardFace.Jack, CardSuit.Diamonds),
               new Card(CardFace.Queen, CardSuit.Hearts),
               new Card(CardFace.Four, CardSuit.Spades),
               new Card(CardFace.Seven, CardSuit.Clubs),
               new Card(CardFace.Ace, CardSuit.Spades)
           );
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFourOfAKind()
        {
            Hand hand = new Hand(
               new Card(CardFace.Ace, CardSuit.Diamonds),
               new Card(CardFace.Ace, CardSuit.Hearts),
               new Card(CardFace.Four, CardSuit.Spades),
               new Card(CardFace.Ace, CardSuit.Clubs),
               new Card(CardFace.Ace, CardSuit.Spades)
            );
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlush()
        {
            Hand hand = new Hand(
               new Card(CardFace.Jack, CardSuit.Spades),
               new Card(CardFace.Queen, CardSuit.Spades),
               new Card(CardFace.Four, CardSuit.Spades),
               new Card(CardFace.Ace, CardSuit.Spades),
               new Card(CardFace.Eight, CardSuit.Spades)
            );
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }
    }
}
