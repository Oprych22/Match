using System;
using Match;
using Match.Game;

namespace MatchGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchType = GetMatchConditionType();

            // In real world application, would use DI container here.
            var builder = new Builder();

            var matchConditionFactory = builder.GetMatchConditionFactory();
            var matchCondition = matchConditionFactory.GetMatchCondition(matchType); // Needs to be enum not int.

            int numDecks = GetNumDecks();

            var gameFactory = builder.GetGameFactory();
            var game = gameFactory.GetGame(matchCondition, numDecks);
            
            game.RunGame();
        }

        private static int GetMatchConditionType()
        {
            Console.WriteLine("Hello. To play the Game please enter the type of game:");
            Console.WriteLine("0 - Suit Match");
            Console.WriteLine("1 - Value Match");
            Console.WriteLine("2 - Suit & Value Match");
            var gameTypeString = Console.In.ReadLine();
            
            
            if (!string.IsNullOrWhiteSpace(gameTypeString) && int.TryParse(gameTypeString, out var gameType))
            {
                return gameType;
            }
            else
            {
                throw new Exception("Invalid Option");
            }
        }

        private static int GetNumDecks()
        {
            Console.WriteLine("Now Enter the Number of decks of cards to use:");
            var deckString = Console.In.ReadLine();

            if (!string.IsNullOrWhiteSpace(deckString) && int.TryParse(deckString, out var decks))
            {
                return decks;
            }
            else
            {
                throw new Exception("Invalid Option");
            }
        }
    }
}