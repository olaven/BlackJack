using System;
using System.Collections.Generic;

namespace BlackJack
{
    public abstract class Deck
    {
        protected List<Card> _cards = new List<Card>();

        public Deck()
        {
            Build();
        }

        /// <summary>
        /// Should populate the _cards 
        /// </summary>
        public abstract void Build();

        public Card Draw()
        {
            if (_cards.Count < 0)
                throw new Exception("No cards left");

            int index = new Random().Next(_cards.Count);
            Card card = _cards[index];
            _cards.Remove(card);

            return card;
        }

        public void Add(Card card)
        {
            _cards.Add(card);
        }

        public void Remove(Card card)
        {
            _cards.Remove(card);
        }
    }


    public class FrenchDeck : Deck
    {
        public override void Build()
        {
            Suit[] suits =
            {
                Suit.CLUBS, Suit.DIAMONDS,
                Suit.HEARTS, Suit.SPADES
            };
            Rank[] ranks =
            {
                Rank.ACE, Rank.TWO, Rank.THREE, Rank.FOUR,
                Rank.FIVE, Rank.SIX, Rank.SEVEN, Rank.EIGHT,
                Rank.NINE, Rank.TEN, Rank.JACK, Rank.QUEEN,
                Rank.KING
            };

            int suitCount = -1;
            int rankCount = 0;

            for (int i = 0; i < 52; i++)
            {
                rankCount++; 
                if (i % 13 == 0)
                {
                    suitCount++; 
                    rankCount = 0;
                }

                Card card = new Card();
                card.Rank = ranks[rankCount];
                card.Suit = suits[suitCount];

                Add(card);
            }
        }
    }



}
