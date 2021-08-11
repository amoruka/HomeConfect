using Abstractions.Commands;

using HomeConfect.Domain.CommandContext;
using HomeConfect.Domain.Entities;

namespace HomeConfect.Domain.Services.Recipes
{
    public class RecipeService : IRecipeService
    {
        private readonly ICommandBuilder commandBuilder;

        public RecipeService(ICommandBuilder builder)
        {
            commandBuilder = builder;
        }

        public void SaveRecipe(Recipe recipe)
        {
            commandBuilder.Execute(new AddRecipeContext(recipe));
        }
    }
}
