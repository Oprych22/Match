using System;
using Match;
using Match.Game;

namespace MatchGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. To play the Game please enter the type of game:");
            Console.WriteLine("0 - Suit Match");
            Console.WriteLine("1 - Value Match");
            Console.WriteLine("2 - Suit & Value Match");
            var gameTypeString = Console.In.ReadLine();
            Console.WriteLine("Now Enter the Number of decks of cards to use:");
            var deckString = Console.In.ReadLine();
            IMatchCondition matchCondition;
            if (!string.IsNullOrWhiteSpace(gameTypeString) && int.TryParse(gameTypeString, out var gameType) && !string.IsNullOrWhiteSpace(deckString) && int.TryParse(deckString, out var decks))
            {
                switch (gameType)
                {
                    case 0:
                        matchCondition = new SuitMatch();
                        break;
                    case 1:
                        matchCondition = new ValueMatch();
                        break;
                    case 2:
                        matchCondition = new SuitAndValueMatch();
                        break;
                    
                    default:
                        throw new Exception("Invalid GameType Option");
                    
                }

                var game = new Game(matchCondition, decks);
                game.RunGame();
            }
            else
            {
                throw new Exception("Invalid Option");
            }
            
        }
    }
}