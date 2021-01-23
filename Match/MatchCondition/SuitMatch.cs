namespace Match
{
    public class SuitMatch : IMatchCondition
    {
        
        public bool IsMatch(Card card1, Card card2)
        {
            return card1.Suit == card2.Suit;
        }
    }
}