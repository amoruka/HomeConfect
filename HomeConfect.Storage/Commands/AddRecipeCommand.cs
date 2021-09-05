using Abstractions.Commands;

using HomeConfect.Domain.CommandContext;

namespace HomeConfect.Storage.Commands
{
    public class AddRecipeCommand : AbstractRepository, ICommand<AddRecipeContext>
    {
        public AddRecipeCommand(Context context) : base(context) { }

        public void Execute(AddRecipeContext context)
        {
            Context.Recipes.Add(context.Recipe);

            Context.SaveChanges();
        }
    }
}
