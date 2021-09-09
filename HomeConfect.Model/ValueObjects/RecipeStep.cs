using Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain
{
    [Table(nameof(RecipeStep))]
    public class RecipeStep : IValueObject
    {
        public int Id { get; set; }

        public int Number { get; protected set; }

        public string Description { get; set; }

        internal void SetNumber(int number)
        {
            Number = number;
        }
    }
}
