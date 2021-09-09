using HomeConfect.Core;
using HomeConfect.Domain;
using HomeConfect.Domain.Entities;
using HomeConfect.Domain.Services.Products;
using HomeConfect.Domain.Services.Recipes;
using HomeConfect.Domain.Services.Scales;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace HomeConfect.ViewModels
{
    public class RecipeAddViewModel : ObservableObject
    {
        private readonly IRecipeService recipeService;

        public RecipeViewModel RecipeVM { get; }

        public List<Product> Products { get; }

        public List<Scale> Scales { get; }

        public RelayCommand Save { get; set; }

        public RelayCommand AddIngredient { get; set; }

        public RelayCommand AddRecipeStep { get; set; }

        public RecipeAddViewModel(IRecipeService service, IProductService productService, IScaleService scaleService)
        {
            RecipeVM = new RecipeViewModel(new Recipe());

            RecipeVM.Recipe.Ingredients.CollectionChanged += Ingredients_CollectionChanged;
            RecipeVM.Recipe.Steps.CollectionChanged += Steps_CollectionChanged;

            recipeService = service ?? throw new ArgumentNullException(nameof(service));

            Products = productService.GetProducts().ToList();
            Scales = scaleService.GetScales().ToList();

            // TODO: убрать определение команд из конструктора
            Save = new RelayCommand(o =>
            {
                recipeService.SaveRecipe(RecipeVM.Recipe);

                Mediator.Notify("GoToRecipeBook", "");
            });

            AddIngredient = new RelayCommand(o =>
            {
                RecipeVM.Recipe.Ingredients.Add(new Ingredient());
            });

            AddRecipeStep = new RelayCommand(o =>
            {
                RecipeVM.Recipe.AddRecipeStep(new RecipeStep());
            });
        }

        private void Steps_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems?.Count == 1)
            {
                RecipeVM.Steps.Add(new StepViewModel((RecipeStep)e.NewItems[0]));
            }
        }

        private void Ingredients_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems?.Count == 1)
            {
                RecipeVM.Ingredients.Add(new IngredientViewModel((Ingredient)e.NewItems[0]));
            }
        }
    }
}
