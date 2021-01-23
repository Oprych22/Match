using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Match
{
    public class Deck : Stack<Card>, IDeck
    {
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
        private static IEnumerable<Card> GetPack()
        {
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            var values = Enum.GetValues(typeof(Value)).Cast<Value>();
            return values.SelectMany(s => suits, (x, y) => new Card(x, y));
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

        public Card NextCard()
        {
            return Pop();
        }

        public int CardCount()
        {
            return Count;
        }
    }
}