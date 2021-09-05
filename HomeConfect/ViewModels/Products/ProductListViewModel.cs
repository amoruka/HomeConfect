using HomeConfect.Core;
using HomeConfect.Domain.Entities;
using HomeConfect.Domain.Services.Products;
using System;
using System.Collections.ObjectModel;

namespace HomeConfect.ViewModels
{
    public class ProductListViewModel : ObservableObject
    {
        private readonly IProductService productService;

        public ObservableCollection<Product> Products { get; set; }

        public Product CurrentProduct { get; set; }

        public RelayCommand AddProduct { get; set; }

        public ProductListViewModel(IProductService service)
        {
            productService = service ?? throw new ArgumentNullException(nameof(service));

            Products = productService.GetProducts();

            Products.CollectionChanged += Products_CollectionChanged;

            CurrentProduct = new Product();

            AddProduct = new RelayCommand(o =>
            {
                Products.Add(CurrentProduct);
                CurrentProduct = new Product();
            });
        }

        private void Products_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems?.Count == 1)
            {
                productService.SaveProduct((Product)e.NewItems[0]);
            }
        }
    }
}
