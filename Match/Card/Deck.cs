using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Match
{
    public class Deck : Stack<Card>, IDeck
    {
        private readonly string[] _values = new[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        public Deck(int packs)
        {
            for (var i = 0; i < packs; i++)
            {
                foreach (var card in GetPack())
                {
                    this.Push(card);
                }
            }
        }
        private IEnumerable<Card> GetPack()
        {
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            return _values.SelectMany(s => Enum.GetValues(typeof(Suit)).Cast<Suit>(), (x, y) => new Card(x, y));
        }

        public void Shuffle()
        {
            var cards = new List<Card>();
            while (TryPop(out var card))
            {
                cards.Add(card);
            }
            foreach (var card in cards.OrderBy(x => Guid.NewGuid()).ToList())
            {
                Push(card);
            }
        }
    }
}