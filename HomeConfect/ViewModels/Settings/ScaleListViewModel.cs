using HomeConfect.Core;
using HomeConfect.Domain.Entities;
using HomeConfect.Domain.Services.Scales;

using System;
using System.Collections.ObjectModel;

namespace HomeConfect.ViewModels
{
    public class ScaleListViewModel : ObservableObject
    {
        private readonly IScaleService scaleService;
        public ObservableCollection<Scale> Scales { get; set; }

        private Scale CurrentScale { get; set; }

        public ScaleListViewModel(IScaleService service)
        {
            scaleService = service ?? throw new ArgumentNullException(nameof(service));

            Scales = scaleService.GetScales();

            CurrentScale = new Scale();
        }
    }
}
