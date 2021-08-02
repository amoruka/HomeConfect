namespace Abstractions.Queries
{
    public interface IQuery<in TCriterion, TResult> where TCriterion : ICriterion
    {
        TResult Ask(TCriterion criterion);
    }
}
