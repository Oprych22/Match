using System.Linq;
using NUnit.Framework;
using Match;
using Match.Game;

namespace MatchTest
{
    public class Tests
    {
        private Game _game;
        [SetUp]
        public void Setup()
        {
            _game = new Game(new SuitMatch(), 5);
        }

        [Test]
        public void TestALotOfPacksGame()
        {
            _game = new Game(new SuitMatch(), 10000);
            _game.RunGame();

        }


    }
}