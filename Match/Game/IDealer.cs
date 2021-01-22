namespace Match.Game
{
    public interface IDealer
    {
        public void Shuffle();

        public Card Deal();
    }
}