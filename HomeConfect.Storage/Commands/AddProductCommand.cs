using Abstractions.Commands;

using HomeConfect.Domain.CommandContext;
using HomeConfect.Storage.Queries;

namespace HomeConfect.Storage.Commands
{
    public class AddProductCommand : AbstractQuery, ICommand<AddProductContext>
    {
        public AddProductCommand(Context context) : base(context) { }

        public void Execute(AddProductContext context)
        {
            Context.Products.Add(context.Product);

            Context.SaveChanges();
        }
    }
}
