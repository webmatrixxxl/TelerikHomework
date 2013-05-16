using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            return hand.Cards.Count() == 5;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int times = 4;
            return hand.Cards.GroupBy(card => card.Face).Select(group => group.Count()).Contains(times);
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool isHandValid = IsValidHand(hand);
            bool isAllCardsTheSameColor = IsAllCardsTheSameColor(hand);
            bool isAllCardsConsecutive = IsAllCardsConsecutive(hand);
            bool isFlush = false;

            if (isHandValid == true && isAllCardsTheSameColor == true &&
                isAllCardsConsecutive == false)
            {
                isFlush = true;
            }

            return isFlush;
        }
        private static bool IsAllCardsConsecutive(IHand hand)
        {
            bool isAllCardsConsecutive = true;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if ((int)hand.Cards[i].Face != (int)hand.Cards[i + 1].Face + 1)
                {
                    isAllCardsConsecutive = false;
                    break;
                }
            }

            return isAllCardsConsecutive;
        }

        private static bool IsAllCardsTheSameColor(IHand hand)
        {
            bool isAllCardsTheSameColor = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    isAllCardsTheSameColor = false;
                    break;
                }
            }

            return isAllCardsTheSameColor;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
            //    int[] faceCounts = CalFacesCounts(hand);
            //    int[] suitsCounts = CalSuitsCounts(hand);
        }

        //private int[] CalSuitsCounts(IHand hand)
        //{
        //    int[] suitsCounts = new int[4];

        //    foreach (var cards in hand.Cards)
        //    {
        //        int faceNum = (int)cards.Face;
        //        suitsCounts[faceNum]++;
        //    }

        //    return suitsCounts;
        //}

        //private int[] CalFacesCounts(IHand hand)
        //{
        //    int[] facesCounts = new int[(int)CardFace.Ace + 1];

        //    foreach (var cards in hand.Cards)
        //    {
        //        int faceNum = (int)cards.Face;
        //        facesCounts[faceNum]++;
        //    }

        //    return facesCounts;
        //}

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
