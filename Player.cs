using System;
namespace BlackJack
{
    public class Player : Participant
    {
        public String Name { get; set; }
        public Player (String name = "Player 1")
        {
            Name = name; 
        }
    }
}
