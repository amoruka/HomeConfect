using HomeConfect.Core;

namespace HomeConfect.ViewModels
{
    public class MainViewModel : ViewModelWithCurrentView
    {
        public RecipeBookViewModel RecipeBookVM { get; set; }

        public CalendarViewModel CalendarVM { get; set; }

        public RelayCommand RecipeBookCommand { get; set; }

        public RelayCommand CalendarCommand { get; set; }

        public MainViewModel()
        {
            RecipeBookVM = new RecipeBookViewModel();
            CalendarVM = new CalendarViewModel();

            CurrentView = RecipeBookVM;

            RecipeBookCommand = new RelayCommand(o =>
            {
                CurrentView = RecipeBookVM;
            });

            CalendarCommand = new RelayCommand(o =>
            {
                CurrentView = CalendarVM;
            });
        }
    }
}
