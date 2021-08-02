using Abstractions.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain
{
    [Table(nameof(Recipe))]
    public class Recipe : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Срок хранения.
        /// </summary>
        public string BestBefore { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<RecipeStep> Steps { get; set; }
    }
}
