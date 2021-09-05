using Abstractions.Queries;

using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Storage.Queries
{
    public class GetProductsQuery : AbstractRepository, IQuery<GetProductsCriterion, ObservableCollection<Product>>
    {
        public GetProductsQuery(Context context) : base(context) { }

        public ObservableCollection<Product> Ask(GetProductsCriterion criterion)
        {
            return new ObservableCollection<Product>(Context.Products);
        }
    }
}
