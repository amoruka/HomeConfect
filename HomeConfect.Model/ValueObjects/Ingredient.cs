using Abstractions.Domain;
using HomeConfect.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain
{
    [Table(nameof(Ingredient))]
    public class Ingredient : IValueObject
    {
        public int Id { get; set; }

        public decimal Count { get; set; }

        [Required]
        public Scale Scale { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public Recipe Recipe { get; set; }
    }
}
