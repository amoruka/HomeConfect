namespace Abstractions.Queries
{
    public interface IQueryBuilder
    {
        IQueryFor<TResult> ForResult<TResult>();
    }
}
