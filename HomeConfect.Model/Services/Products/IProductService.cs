using Abstractions.Domain;

using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Products
{
    public interface IProductService : IDomainService
    {
        public ObservableCollection<Product> GetProducts();

        public void SaveProduct(Product product);
    }
}
