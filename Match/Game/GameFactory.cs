using System;
using System.Collections.Generic;

namespace Match.Game
{
    public interface IGameFactory
    {
        IGame GetGame(IMatchCondition matchCondition, int decks);
    }

    public class GameFactory : IGameFactory
    {
        // Need to add IGame interface.
        public IGame GetGame(IMatchCondition matchCondition, int decks)
             // Note to Mike: Could also create players/dealer here, or in the Builder and pass them in.
            => new Game(matchCondition, decks);
    }
}