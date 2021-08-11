using Abstractions.Commands;

using HomeConfect.Domain.Entities;

namespace HomeConfect.Domain.CommandContext
{
    public class AddRecipeContext : ICommandContext
    {
        public Recipe Recipe { get; }

        public AddRecipeContext(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
}
