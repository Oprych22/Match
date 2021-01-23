using System.Collections.Generic;

namespace Match
{
    public class Player : IPlayer
    {
        private readonly List<Card> _cards;

        public Player(string name)
        {
            Name = name;
            _cards = new List<Card>();
        }

        public string Name { get; }
        public int GetCardCount() => _cards.Count;

        public void GiveCards(IEnumerable<Card> cards)
        {
            _cards.AddRange(cards);
        }

    }
}