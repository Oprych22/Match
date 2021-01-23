using System.Collections.Generic;

namespace Match
{
    public interface IDeck
    {
        public void Shuffle();

        public Card NextCard();

        public int CardCount();

    }
}