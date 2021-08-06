using HomeConfect.Core;

using System.Windows;
using System.Windows.Controls;

namespace HomeConfect.Views.Controls
{
    /// <summary>
    /// Логика взаимодействия для CommandBar.xaml
    /// </summary>
    public partial class CommandBar : UserControl
    {
        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register("Title", typeof(string), typeof(CommandBar));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty AddObjectProperty =
            DependencyProperty.Register(
                "AddObject",
                typeof(RelayCommand),
                typeof(CommandBar),
                new UIPropertyMetadata(null));

        public RelayCommand AddObject
        {
            get => (RelayCommand)GetValue(AddObjectProperty);
            set => SetValue(AddObjectProperty, value);
        }


        public CommandBar()
        {
            InitializeComponent();
        }
    }
}
