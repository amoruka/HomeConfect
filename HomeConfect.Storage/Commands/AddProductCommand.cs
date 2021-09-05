using Abstractions.Commands;

using HomeConfect.Domain.CommandContext;

namespace HomeConfect.Storage.Commands
{
    public class AddProductCommand : AbstractRepository, ICommand<AddProductContext>
    {
        public AddProductCommand(Context context) : base(context) { }

        public void Execute(AddProductContext context)
        {
            Context.Products.Add(context.Product);

            Context.SaveChanges();
        }
    }
}
