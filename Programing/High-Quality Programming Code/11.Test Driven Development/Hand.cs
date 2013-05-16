using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(params ICard[] cards)
        {
            this.Cards = new List<ICard>();
            for (int i = 0; i < cards.Length; i++)
            {
                this.Cards.Add(cards[i]);
            }

        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var card in this.Cards)
            {
                result.Append(card.ToString());
            }

            return result.ToString();
        }
    }
}
