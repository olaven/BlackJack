using System;
namespace BlackJack
{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }
    }

    public enum Rank
    {
        ACE, TWO, THREE, FOUR,
        FIVE, SIX, SEVEN, EIGHT,
        NINE, TEN, JACK, QUEEN,
        KING
    }

    public enum Suit 
    {
        HEARTS, DIAMONDS, 
        CLUBS, SPADES
    }
}
