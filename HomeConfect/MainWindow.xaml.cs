using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Services.Recipes;
using HomeConfect.Storage;
using HomeConfect.Storage.Queries;
using HomeConfect.ViewModels;

using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HomeConfect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context dataContext;

        public MainWindow(Context context, IRecipeService recipeService)
        {
            InitializeComponent();

            dataContext = context;

            // TODO ?
            DataContext = new MainViewModel(recipeService)
            {
                RecipeBookVM = new RecipeBookViewModel(recipeService)
                {
                    CurrentView = new RecipeTilesFeedViewModel
                    {
                        RecipeTiles = new GetAllRecipesQuery(context)
                            .Ask(new GetAllRecipes())
                            .Select(x => new RecipeTileViewModel(x))
                            .ToList(),
                        Recipes = context.Recipes.Local.ToObservableCollection()
                    }
                }
            };
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                ttRecipeBook.Visibility = Visibility.Collapsed;
                ttCalendar.Visibility = Visibility.Collapsed;
                ttShopingList.Visibility = Visibility.Collapsed;
                ttSettings.Visibility = Visibility.Collapsed;
                ttSignout.Visibility = Visibility.Collapsed;
            }
            else
            {
                ttRecipeBook.Visibility = Visibility.Visible;
                ttCalendar.Visibility = Visibility.Visible;
                ttShopingList.Visibility = Visibility.Visible;
                ttSettings.Visibility = Visibility.Visible;
                ttSignout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
