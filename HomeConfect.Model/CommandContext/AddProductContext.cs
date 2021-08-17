using Abstractions.Commands;

using HomeConfect.Domain.Entities;

namespace HomeConfect.Domain.CommandContext
{
    public class AddProductContext : ICommandContext
    {
        public Product Product { get; }

        public AddProductContext(Product product)
        {
            Product = product;
        }
    }
}
