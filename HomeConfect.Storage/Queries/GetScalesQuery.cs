using Abstractions.Queries;

using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Storage.Queries
{
    public class GetScalesQuery : AbstractRepository, IQuery<GetScalesCriterion, ObservableCollection<Scale>>
    {
        public GetScalesQuery(Context context) : base(context) { }

        public ObservableCollection<Scale> Ask(GetScalesCriterion criterion)
        {
            return new ObservableCollection<Scale>(Context.Scales);
        }
    }
}
