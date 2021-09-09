using HomeConfect.Core;
using HomeConfect.Domain.Entities;

using System;
using System.Collections.ObjectModel;

namespace HomeConfect.ViewModels
{
    public class RecipeViewModel : ObservableObject
    {
        public readonly Recipe Recipe;

        public string Name
        {
            get => Recipe.Name;
            set
            {
                Recipe.Name = value;
                OnPropertyChanged(nameof(Recipe.Name));
            }
        }

        public string Description
        {
            get => Recipe.Description;
            set
            {
                Recipe.Description = value;
                OnPropertyChanged(nameof(Recipe.Description));
            }
        }

        public string BestBefore
        {
            get => Recipe.BestBefore;
            set
            {
                Recipe.BestBefore = value;
                OnPropertyChanged(nameof(Recipe.BestBefore));
            }
        }

        public string Source
        {
            get => Recipe.Source;
            set
            {
                Recipe.Source = value;
                OnPropertyChanged(nameof(Recipe.Source));
            }
        }

        public ObservableCollection<IngredientViewModel> Ingredients { get; init; }

        public ObservableCollection<StepViewModel> Steps { get; init; }

        public RecipeViewModel(Recipe recipe)
        {
            Recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));

            Ingredients = new ObservableCollection<IngredientViewModel>();
            Steps = new ObservableCollection<StepViewModel>();
        }
    }
}
