using System;
using System.Collections;

namespace Match.Game
{
    public class Dealer: IDealer
    {
        private Deck _deck;

        public Dealer(int packs)
        {
            _deck = new Deck(packs);
        }
        
        public void Shuffle()
        {
            _deck.Shuffle();
        }
        
        public Card Deal()
        {
            return _deck.Pop();
        }

        public bool PeekAtDeck()
        {
            return _deck.Count > 0;
        }
    }
}