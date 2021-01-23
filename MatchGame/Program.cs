using System;
using System.Collections.Generic;
using Match;
using Match.Game;

namespace MatchGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(TryGetMatchCondition(), TryGetDecks());
            game.RunGame();
        }

        static int TryGetDecks()
        {
            Console.WriteLine("Now Enter the Number of decks of cards to use:");
            var deckString = Console.In.ReadLine();
            if (!string.IsNullOrWhiteSpace(deckString) && int.TryParse(deckString, out var decks))
            {
                return decks;
            }
            else
            {
                throw new Exception("Invalid Deck Option");
            }
        }

        static IMatchCondition TryGetMatchCondition()
        {
            Console.WriteLine("Hello. To play the Game please enter the type of game:");
            Console.WriteLine("0 - Suit Match");
            Console.WriteLine("1 - Value Match");
            Console.WriteLine("2 - Suit & Value Match");
            var gameTypeString = Console.In.ReadLine();
            if (!string.IsNullOrWhiteSpace(gameTypeString) && int.TryParse(gameTypeString, out var gameType))
            {
                switch (gameType)
                {
                    case 0:
                        return new SuitMatch();
                        break;
                    case 1:
                        return new ValueMatch();
                        break;
                    case 2:
                        return new CompositeMatchCondition(new List<IMatchCondition>()
                            {new SuitMatch(), new ValueMatch()});
                        break;

                    default:
                        throw new Exception("Invalid GameType Option");

                }
            }
            else
            {
                throw new Exception("Invalid GameType Option");
            }
        }
    }
}