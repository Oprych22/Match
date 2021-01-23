namespace Match
{
    public class ValueMatch : IMatchCondition
    {
        public bool IsMatch(Card card1, Card card2)
        {
            return card1.Value == card2.Value;
        }
    }
}