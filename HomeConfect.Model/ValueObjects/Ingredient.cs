using Abstractions.Domain;
using HomeConfect.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain
{
    [Table(nameof(Ingredient))]
    public class Ingredient : IValueObject
    {
        public int Id { get; set; }

        public decimal Count { get; set; }

        public Scale Scale { get; set; }

        public Product Product { get; set; }

        public Recipe Recipe { get; set; }
    }
}
