using System.Collections.Generic;

namespace Match
{
    public class Player : IPlayer
    {
        private readonly List<Card> _cards;
        private readonly string _name; 

        public Player(string name)
        {
            _name = name;
            _cards = new List<Card>();
        }
        public int GetCardCount() => _cards.Count;

        public void GiveCards(IEnumerable<Card> cards)
        {
            _cards.AddRange(cards);
        }

        public string GetName() => _name;
    }
}