using System;
namespace BlackJack
{
    public class BlackJackGame : Game
    {

        internal Player player;
        internal Dealer dealer;
        private Client _client; 

        public BlackJackGame()
        {
            player = new Player();
            dealer = new Dealer();

            _client = new Client(this); 

            Setup(); 
        }


        protected override void Setup()
        {
            dealer.DealCardTo(dealer);
        }

        internal override void Start()
        {
            while (true) 
            {
                dealer.DealCardTo(player);
                _client.DisplayStatus();

                if (player.Sum <= 21 && _client.PlayerWantsToHit())
                    continue;
                break; 
            }

            End(); 
        }

        protected override void End() 
        {
            while(dealer.Sum < 17) 
            {
                dealer.DealCardTo(dealer); 
            }

            _client.DisplayStatus(); 

            if(dealer.Sum >= player.Sum) 
            {
                _client.DisplayMessage("Dealer won"); 
            } 
            else 
            {
                _client.DisplayMessage(player.Name + " won!"); 
            }
        }
    }
}
