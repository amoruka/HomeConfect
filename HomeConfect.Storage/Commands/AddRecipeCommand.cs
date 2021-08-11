using Abstractions.Commands;

using HomeConfect.Domain.CommandContext;
using HomeConfect.Storage.Queries;

namespace HomeConfect.Storage.Commands
{
    public class AddRecipeCommand : AbstractQuery, ICommand<AddRecipeContext>
    {
        public AddRecipeCommand(Context context) : base(context) { }

        public void Execute(AddRecipeContext context)
        {
            Context.Recipes.Add(context.Recipe);

            Context.SaveChanges();
        }
    }
}
