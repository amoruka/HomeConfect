namespace HomeConfect.Core
{
    public abstract class ViewModelWithCurrentView : ObservableObject
    {
        private object currentView;

        public object CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }
    }
}
