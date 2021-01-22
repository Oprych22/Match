using System.Collections.Generic;

namespace Match
{
    public interface IPlayer
    {
        public string GetName();
        public int GetCardCount();

        public void GiveCards(IEnumerable<Card> cards);

    }
}