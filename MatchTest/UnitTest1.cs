using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Match;
using Match.Game;

namespace MatchTest
{
    public class Tests
    {
        private Game _game;
        private Card _card1;
        private Card _card2;
        private Card _card3;
        private Card _card4;
        
        [SetUp]
        public void Setup()
        {
            _game = new Game(new SuitMatch(), 5);
            _card1 = new Card(Value.Ace, Suit.Clubs);
            _card2 = new Card(Value.Eight, Suit.Diamonds);
            _card3 = new Card(Value.Ace, Suit.Diamonds);
            _card4 = new Card(Value.Eight, Suit.Diamonds);
        }

        [Test]
        public void TestSuitMatch()
        {
            var suitMatch = new SuitMatch();
            Assert.IsFalse(suitMatch.IsMatch(_card1, _card3));
            Assert.IsTrue(suitMatch.IsMatch(_card2, _card3));

        }
        
        [Test]
        public void TestValueMatch()
        {
            var valueMatch = new ValueMatch();
            Assert.IsTrue(valueMatch.IsMatch(_card1, _card3));
            Assert.IsFalse(valueMatch.IsMatch(_card2, _card3));
        }
        
        [Test]
        public void TestSuitAndValueMatch()
        {
            var suitAndValue = new CompositeMatchCondition(new IMatchCondition[] {new SuitMatch(), new ValueMatch()});
            Assert.IsTrue(suitAndValue.IsMatch(_card2, _card4));
            Assert.IsFalse(suitAndValue.IsMatch(_card1, _card3));
            Assert.IsFalse(suitAndValue.IsMatch(_card2, _card3));

        }


    }
}