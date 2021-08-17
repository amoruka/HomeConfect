using System;

namespace Abstractions.Queries
{
    public class DefaultQueryFor<TResult> : IQueryFor<TResult>
    {
        private readonly IQueryFactory queryFactory;

        public DefaultQueryFor(IQueryFactory factory)
        {
            queryFactory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public TResult WithCriterion<TCriterion>(TCriterion criterion) where TCriterion : ICriterion
        {
            return queryFactory.Create<TCriterion, TResult>().Ask(criterion);
        }
    }
}
