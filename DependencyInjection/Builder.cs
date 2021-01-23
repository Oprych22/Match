namespace DependencyInjection
{
    public class Builder
    {
        public IMatchConditionFactory GetMatchConditionFactory()
            => new MatchConditionFactory();

        public IGameFactory GetGameFactory()
            => new GameFactory();
    }
}