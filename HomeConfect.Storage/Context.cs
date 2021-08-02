using HomeConfect.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeConfect.Storage
{
    public class Context : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Scale> Scales { get; set;}

        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
