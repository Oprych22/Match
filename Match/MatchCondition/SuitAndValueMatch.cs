namespace Match
{
    public class SuitAndValueMatch : IMatchCondition
    {
        public bool Match(Card card1, Card card2)
        {
            return card1.Equals(card2);
        }
    }
}