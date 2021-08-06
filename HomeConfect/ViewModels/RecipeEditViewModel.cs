using HomeConfect.Domain;

namespace HomeConfect.ViewModels
{
    public class RecipeEditViewModel
    {
        private readonly Recipe Recipe;

        public RecipeEditViewModel(Recipe recipe)
        {
            Recipe = recipe;
        }

        public RecipeEditViewModel(object obj)
        {

        }
    }
}
