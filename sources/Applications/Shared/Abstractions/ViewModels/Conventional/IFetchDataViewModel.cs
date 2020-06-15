using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public interface IFetchDataViewModel
        : IDisposable
    {
        ICollection<IWeatherForecastDTO> Forecasts { get; }
        Task GetForecastAsync(DateTime startDate);
    }
}