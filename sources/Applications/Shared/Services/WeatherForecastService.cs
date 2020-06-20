using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Shared.Services
{
    public class WeatherForecastService
        : IWeatherForecastService
    {
        #region Fields

        private readonly IServiceProvider _serviceProvider;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private bool _disposedValue;
        #endregion

        #region Constructors

        public WeatherForecastService(IServiceProvider serviceProvider)
            => _serviceProvider = serviceProvider;

        #endregion

        #region Methods
        public Task<ICollection<IWeatherForecastDTO>> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            ICollection<IWeatherForecastDTO> result = Enumerable.Range(1, 5).Select(index =>
                    {
                        var dto = _serviceProvider.GetRequiredService<IWeatherForecastDTO>();
                        dto.Date = startDate.AddDays(index);
                        dto.TemperatureC = rng.Next(-20, 55);
                        dto.Summary = Summaries[rng.Next(Summaries.Length)];
                        return dto;
                    }
                ).ToList();



            return Task.FromResult(result);
        }
        #endregion

        #region Disposable
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)                    
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~WeatherForecastService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
