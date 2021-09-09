using Abstractions.Domain;

using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Recipes
{
    public interface IRecipeService : IDomainService
    {
        public ObservableCollection<Recipe> GetRecipes();

        public void SaveRecipe(Recipe recipe);
    }
}
