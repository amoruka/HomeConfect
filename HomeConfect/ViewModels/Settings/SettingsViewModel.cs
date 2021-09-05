using HomeConfect.Core;
using HomeConfect.Domain.Services.Products;
using HomeConfect.Domain.Services.Scales;

namespace HomeConfect.ViewModels
{
    public class SettingsViewModel : ViewModelWithCurrentView
    {
        public ProductListViewModel ProductListVM { get; set; }

        public ScaleListViewModel ScaleListVM { get; init; }

        public RelayCommand ProductListCommand { get; }

        public RelayCommand ScaleListCommand { get; }

        public SettingsViewModel(IProductService productService, IScaleService scaleService)
        {
            ProductListVM = new ProductListViewModel(productService);
            ScaleListVM = new ScaleListViewModel(scaleService);

            CurrentView = ProductListVM;

            ProductListCommand = new RelayCommand(o =>
            {
                CurrentView = ProductListVM;
            });

            ScaleListCommand = new RelayCommand(o => { CurrentView = ScaleListVM; });
        }
    }
}
