using System;
namespace BlackJack
{
    public class Client
    {
        private BlackJackGame _game; 
        public Client(BlackJackGame game)
        {
            _game = game; 
        }

        public void DisplayStatus() 
        {
            Console.Write(
                "Dealer: " + _game.dealer.Sum + "\n" +
                "Player: " + _game.player.Sum + "\n"
            );  
        }

        internal bool PlayerWantsToHit()
        {
            while (true) 
            {
                Console.WriteLine("Hit or Stay?");
                var input = Console.ReadLine().ToLower();


                if (input.Equals("hit"))
                {
                    return true;
                }
                else if (input.Equals("stay"))
                {
                    return false;
                }
                Console.WriteLine("Not valid. \"hit\" or \"stay\" are valid.");
            }
        }

        internal void DisplayMessage(String message)
        {
            Console.WriteLine("\n{0}\n", message); 
        }
    }
}
