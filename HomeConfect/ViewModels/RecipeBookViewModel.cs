using HomeConfect.Core;

namespace HomeConfect.ViewModels
{
    public class RecipeBookViewModel : ViewModelWithCurrentView
    {
        public RecipeTilesFeedViewModel RecipeTilesFeedVM { get; set; }

        public RelayCommand RecipeEditCommand { get; set; }

        public RecipeBookViewModel()
        {
            RecipeTilesFeedVM = new RecipeTilesFeedViewModel();
            CurrentView = RecipeTilesFeedVM;

            RecipeEditCommand = new RelayCommand(o =>
            {
                CurrentView = new RecipeEditViewModel(o);
            });
        }
    }
}
