using System;
namespace BlackJack
{
    public abstract class Game
    {

        internal abstract void Start();

        protected abstract void Setup();

        protected abstract void End();
    }
}
