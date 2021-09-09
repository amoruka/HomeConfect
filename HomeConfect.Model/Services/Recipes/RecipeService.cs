using Abstractions.Commands;
using Abstractions.Queries;

using HomeConfect.Domain.CommandContext;
using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System;
using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Recipes
{
    public class RecipeService : IRecipeService
    {
        private readonly ICommandBuilder commandBuilder;
        private readonly IQueryBuilder queryBuilder;

        public RecipeService(ICommandBuilder cBuilder, IQueryBuilder qBuilder)
        {
            commandBuilder = cBuilder ?? throw new ArgumentNullException(nameof(cBuilder));
            queryBuilder = qBuilder ?? throw new ArgumentNullException(nameof(qBuilder));
        }

        public ObservableCollection<Recipe> GetRecipes()
        {
            return queryBuilder.ForResult<ObservableCollection<Recipe>>().WithCriterion(new GetAllRecipes());
        }

        public void SaveRecipe(Recipe recipe)
        {
            commandBuilder.Execute(new AddRecipeContext(recipe));
        }
    }
}
