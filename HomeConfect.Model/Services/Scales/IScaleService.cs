using Abstractions.Domain;

using HomeConfect.Domain.Entities;

using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Scales
{
    public interface IScaleService : IDomainService
    {
        public ObservableCollection<Scale> GetScales();

        public void SaveScale(Scale scale);
    }
}
