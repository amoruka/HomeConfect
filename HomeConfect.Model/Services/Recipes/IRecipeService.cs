using Abstractions.Domain;
using HomeConfect.Domain.Entities;

namespace HomeConfect.Domain.Services.Recipes
{
    public interface IRecipeService : IDomainService
    {
        public void SaveRecipe(Recipe recipe);
    }
}
