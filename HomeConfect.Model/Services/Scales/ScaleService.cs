using Abstractions.Commands;
using Abstractions.Queries;

using HomeConfect.Domain.Criterion;
using HomeConfect.Domain.Entities;

using System;
using System.Collections.ObjectModel;

namespace HomeConfect.Domain.Services.Scales
{
    public class ScaleService : IScaleService
    {
        private readonly ICommandBuilder commandBuilder;
        private readonly IQueryBuilder queryBuilder;

        public ScaleService(ICommandBuilder cBuilder, IQueryBuilder qBuilder)
        {
            commandBuilder = cBuilder ?? throw new ArgumentNullException(nameof(cBuilder));
            queryBuilder = qBuilder ?? throw new ArgumentNullException(nameof(qBuilder));
        }

        public ObservableCollection<Scale> GetScales()
        {
            return queryBuilder.ForResult<ObservableCollection<Scale>>().WithCriterion(new GetScalesCriterion());
        }

        public void SaveScale(Scale scale)
        {
            throw new NotImplementedException();
        }
    }
}
