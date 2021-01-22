namespace Match
{
    public struct Card
    {
        public readonly Suit Suit { get; }
        public readonly string Value { get; }

        public Card(string value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Card otherCard)
            {
                return this.Suit == otherCard.Suit && this.Value == otherCard.Value;
            }
            else
            {
                return false;
            }
        }
    }
}