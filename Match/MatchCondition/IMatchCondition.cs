namespace Match
{
    public interface IMatchCondition
    {
        public bool IsMatch(Card card1, Card card2);
    }
}