using Abstractions.Queries;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HomeConfect.Storage.Queries
{
    public class QueryFactory : IQueryFactory
    {
        private readonly IServiceProvider serviceProvider;

        private Dictionary<Type, Type> Queries;

        public QueryFactory(IServiceProvider provider)
        {
            serviceProvider = provider ?? throw new ArgumentNullException(nameof(provider));

            LoadQueries();
        }

        public IQuery<TCriterion, TResult> Create<TCriterion, TResult>() where TCriterion : ICriterion
        {
            var incomingContext = typeof(TCriterion);

            var type = Queries[incomingContext];

            if (type is null)
            {
                throw new Exception($"Query with context {nameof(incomingContext)} not found");
            }

            // Service locator?
            return Activator.CreateInstance(type, serviceProvider.GetService(typeof(Context))) as IQuery<TCriterion, TResult>;
        }

        private void LoadQueries()
        {
            Queries = new Dictionary<Type, Type>();

            var queryTypes = Assembly
                                .GetExecutingAssembly()
                                .GetTypes()
                                .Where(x => !x.IsAbstract)
                                .ToList();

            foreach (var queryType in queryTypes)
            {
                var interfaces = queryType.GetInterfaces();

                foreach (var inter in interfaces)
                {
                    var iCriterion = inter.GetGenericArguments().Where(z => z.GetInterface(typeof(ICriterion).Name) != null).FirstOrDefault();

                    if (iCriterion != null)
                    {
                        Queries.Add(iCriterion, queryType);
                    }
                }
            }
        }
    }
}
