using System;
using System.Collections;

namespace Match.Game
{
    public class Dealer: IDealer
    {
        private IDeck _deck;

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
            return _deck.NextCard();
        }

        public bool PeekAtDeck()
        {
            return _deck.CardCount() > 0;
        }
    }
}