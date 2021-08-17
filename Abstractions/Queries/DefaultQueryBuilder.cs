using System;

namespace Abstractions.Queries
{
    public class DefaultQueryBuilder : IQueryBuilder
    {
        private readonly IServiceProvider serviceProvider;

        public DefaultQueryBuilder(IServiceProvider provider)
        {
            serviceProvider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        public IQueryFor<TResult> ForResult<TResult>()
        {
            return Activator.CreateInstance(typeof(DefaultQueryFor<TResult>), serviceProvider.GetService(typeof(IQueryFactory))) as IQueryFor<TResult>;
        }
    }
}
