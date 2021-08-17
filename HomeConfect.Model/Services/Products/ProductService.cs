using Abstractions.Commands;
using Abstractions.Queries;

using HomeConfect.Domain.CommandContext;
using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System;
using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly ICommandBuilder commandBuilder;
        private readonly IQueryBuilder queryBuilder;

        public ProductService(ICommandBuilder cBuilder, IQueryBuilder qBuilder)
        {
            commandBuilder = cBuilder ?? throw new ArgumentNullException(nameof(cBuilder));
            queryBuilder = qBuilder ?? throw new ArgumentNullException(nameof(qBuilder));
        }

        public ObservableCollection<Product> GetProducts()
        {
            return queryBuilder.ForResult<ObservableCollection<Product>>().WithCriterion(new GetProductsCriterion());
        }

        public void SaveProduct(Product product)
        {
            commandBuilder.Execute(new AddProductContext(product));
        }
    }
}
