using System.Collections.Generic;
using System.Net;

namespace Match
{
    public interface IPlayer
    {
        public string Name { get;  }
        public int GetCardCount();

        public void GiveCards(IEnumerable<Card> cards);

    }
}