using HomeConfect.Domain.Criterion;
using HomeConfect.Storage;
using HomeConfect.Storage.Queries;
using HomeConfect.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeConfect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context dataContext;

        public MainWindow(Context context)
        {
            InitializeComponent();

            dataContext = context;

            // TODO ?
            DataContext = new MainViewModel
            {
                RecipeBookVM = new RecipeBookViewModel
                {
                    CurrentView = new RecipeTilesFeedViewModel
                    {
                        RecipeTiles = new GetAllRecipesQuery(context).Ask(new GetAllRecipes()).Select(x => new RecipeTileViewModel(x)).ToList()
                    }
                }
            };
        }
    }
}
