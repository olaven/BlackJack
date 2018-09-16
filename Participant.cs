using System;
namespace BlackJack
{
    public class Participant
    {
        public int Sum { get; set; }

        /// <summary>
        /// Give the card to the player 
        /// </summary>
        /// <param name="card">Card.</param>
        public void ReceiveCard(Card card) 
        {
            int value = 0; 

            switch (card.Rank) //TODO:may not belong to a participant, but to blackjack-specific class 
            {
                case Rank.ACE:
                    value += 1; //TODO: Can be eleven -> ask player 
                    break; 
                case Rank.TWO:
                    value += 2;
                    break; 
                case Rank.THREE:
                    value += 3;
                    break; 
                case Rank.FOUR:
                    value += 4;
                    break; 
                case Rank.FIVE:
                    value += 5;
                    break; 
                case Rank.SIX:
                    value += 6;
                    break; 
                case Rank.SEVEN:
                    value += 7;
                    break; 
                case Rank.EIGHT:
                    value += 8;
                    break; 
                case Rank.NINE:
                    value += 9;
                    break; 
                case Rank.TEN:
                    value += 10;
                    break; 
                case Rank.JACK:
                    value += 11;
                    break; 
                case Rank.QUEEN:
                    value += 12;
                    break; 
                case Rank.KING:
                    value += 13;
                    break; 
                default:
                    throw new Exception("Invalid rank");
            }
            Sum += value; 
        }
    }
}
