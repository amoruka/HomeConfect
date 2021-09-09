using Abstractions.Queries;

using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Storage.Queries
{
    public class GetAllRecipesQuery : AbstractRepository, IQuery<GetAllRecipes, ObservableCollection<Recipe>>
    {
        public GetAllRecipesQuery(Context context) : base(context)
        { }

        public ObservableCollection<Recipe> Ask(GetAllRecipes criterion)
        {
            return new ObservableCollection<Recipe>(Context.Recipes);
        }
    }
}
