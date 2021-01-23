using System;
using System.Collections.Generic;

namespace Match.Game
{
    public class Game
    {
        private readonly IMatchCondition _matchCondition;
        private readonly Random _rdm;
        private readonly IDealer _dealer;
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public Game(IMatchCondition matchCondition, int decks)
        {
            _matchCondition = matchCondition;
            _rdm = new Random();
            _dealer = new Dealer(decks);
            _player1 = new Player("player 1");
            _player2 = new Player("player 2");
        }


        public void Match()
        {
            _dealer.Shuffle();
            if (!_dealer.PeekAtDeck())
                throw new Exception("No Cards in Deck");
            
            var lastCard = _dealer.Deal();
            var cards = new List<Card>() {lastCard};

            while (_dealer.PeekAtDeck())
            {
                var card = _dealer.Deal();
                cards.Add(card);
                if (_matchCondition.IsMatch(lastCard, card))
                {
                    if (_rdm.Next(2) == 1)
                    {
                        _player1.GiveCards(cards);
                    }
                    else
                    {
                        _player2.GiveCards(cards);
                    }

                    if (!_dealer.PeekAtDeck())
                        break;

                    lastCard = _dealer.Deal();
                    cards = new List<Card>() {lastCard};
                }
                else
                {
                    lastCard = card;
                }
            }
        }


        public void RunGame()
        {
            Match();
            if (_player1.GetCardCount() > _player2.GetCardCount())
            {
                Console.Out.WriteLine($"{_player1.Name} is the winner!");
            }
            else if (_player1.GetCardCount() < _player2.GetCardCount())
            {
                Console.Out.WriteLine($"{_player2.Name} is the winner!");
            }
            else
            {
                Console.Out.WriteLine("It's a Draw!");
            }
        }
    }
}