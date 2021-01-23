using System.Collections.Generic;
using System.Linq;

namespace Match
{
    public class CompositeMatchCondition : IMatchCondition
    {
        private readonly IEnumerable<IMatchCondition> _conditions;

        public CompositeMatchCondition(IEnumerable<IMatchCondition> conditions)
        {
            _conditions = conditions;
            
        }

        public bool IsMatch(Card card1, Card card2)
        {
            return _conditions.All(c => c.IsMatch(card1, card2));
        }
    }
}