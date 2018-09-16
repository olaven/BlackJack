using System;
namespace BlackJack
{
    public class Dealer : Participant
    {
        private Deck _deck; 
        public Dealer()
        {
            _deck = new FrenchDeck(); 
        }

        /// <summary>
        /// Gives a card to the specified participant 
        /// </summary>
        /// <param name="participant">Participant.</param>
        public void DealCardTo(Participant participant)
        {
            Card card = _deck.Draw();
            participant.ReceiveCard(card); 
        }
    }
}
