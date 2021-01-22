namespace Match
{
    public interface IMatchCondition
    {
        public bool Match(Card card1, Card card2);
    }
}