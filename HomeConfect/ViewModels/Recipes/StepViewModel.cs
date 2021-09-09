using HomeConfect.Core;
using HomeConfect.Domain;

namespace HomeConfect.ViewModels
{
    public class StepViewModel : ObservableObject
    {
        private RecipeStep Step { get; init; }

        public int Number
        {
            get => Step.Number;
        }

        public string Desciption
        {
            get => Step.Description;
            set
            {
                Step.Description = value;
                OnPropertyChanged(nameof(RecipeStep.Description));
            }
        }

        public StepViewModel(RecipeStep recipeStep)
        {
            Step = recipeStep ?? new RecipeStep();
        }
    }
}
