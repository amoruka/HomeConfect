using HomeConfect.Core;
using HomeConfect.Domain;
using HomeConfect.Domain.Entities;

namespace HomeConfect.ViewModels
{
    public class IngredientViewModel : ObservableObject
    {
        private Ingredient Ingredient { get; init; }

        public decimal Count
        {
            get => Ingredient.Count;
            set
            {
                Ingredient.Count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public Product Product
        {
            get => Ingredient.Product;
            set
            {
                Ingredient.Product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        public Scale Scale
        {
            get => Ingredient.Scale;
            set
            {
                Ingredient.Scale = value;
                OnPropertyChanged(nameof(Scale));
            }
        }

        public IngredientViewModel(Ingredient ingredient)
        {
            Ingredient = ingredient ?? new Ingredient();
        }
    }
}
