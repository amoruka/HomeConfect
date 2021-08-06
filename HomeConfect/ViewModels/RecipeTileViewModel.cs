using HomeConfect.Domain;

namespace HomeConfect.ViewModels
{
    /// <summary>
    /// ViewModel для Рецепта в виде плитки.
    /// </summary>
    public class RecipeTileViewModel
    {
        private readonly Recipe Recipe;

        public string Name => Recipe.Name;

        public RecipeTileViewModel(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
}
