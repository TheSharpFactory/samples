using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Shared.Services
{
    public interface IWeatherForecastService
        : IDisposable
    {
        Task<ICollection<IWeatherForecastDTO>> GetForecastAsync(DateTime startDate);
    }
}