namespace Abstractions.Queries
{
    public interface IQueryFor<TResult>
    {
        TResult WithCriterion<TCriterion>(TCriterion criterion) where TCriterion : ICriterion;
    }
}
