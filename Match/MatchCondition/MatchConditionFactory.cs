using System;

namespace Match.MatchCondition
{
    public enum MatchConditionType
    {
        Suit = 0,
        Value = 1,
        SuitAndValue = 2,
    }

    public interface IMatchConditionFactory
    {
        IMatchCondition GetMatchCondition(MatchConditionType conditionType);
    }

    // Factory pattern.
    public class MatchConditionFactory : IMatchConditionFactory
    {
        public IMatchCondition GetMatchCondition(MatchConditionType conditionType)
        {
            switch (conditionType)
            {
                case MatchConditionType.Suit:
                    return new SuitMatch();
                case MatchConditionType.Value:
                    return new ValueMatch();
                case MethodCodeType.SuitAndValue:
                    return new SuitAndValueMatch();
                default:
                    throw new ArgumentException(nameof(conditionType), $"Unexpected {nameof(MatchConditionType)}: {conditionType}.");
            }
        }
    }
}