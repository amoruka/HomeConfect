using Abstractions.Domain;

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain.Entities
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

        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public ObservableCollection<RecipeStep> Steps { get; }

        public Recipe()
        {
            Steps = new ObservableCollection<RecipeStep>();
            Ingredients = new ObservableCollection<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            ingredient.Recipe = this;

            Ingredients.Add(ingredient);
        }

        public void AddRecipeStep(RecipeStep newStep)
        {
            newStep.SetNumber(Steps.Count + 1);

            Steps.Add(newStep);
        }
    }
}
