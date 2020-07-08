using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using TheSharpFactory.Apps.Shared.Services;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class FetchDataViewModel
        : IFetchDataViewModel
    {
        #region Fields
        private readonly IWeatherForecastService _service;
        private Task _getForecastsAsyncTask;
        private bool _disposedValue;
        #endregion

        #region Properties
        public ICollection<IWeatherForecastDTO> Forecasts { get; private set; }
            = new List<IWeatherForecastDTO>();
        #endregion

        #region Constructors
        public FetchDataViewModel(IWeatherForecastService service)
        {
            _service = service;
            _getForecastsAsyncTask = GetForecastsAsyncTask(DateTime.Now);
        }
        #endregion

        #region Private Methods
        private async Task GetForecastsAsyncTask(DateTime startDate)
            => Forecasts = await _service.GetForecastAsync(startDate).ConfigureAwait(false);
        #endregion

        #region Public Methods
        public Task GetForecastAsync(DateTime startDate)
        {

            if (_getForecastsAsyncTask?.IsCompleted ?? true)
                _getForecastsAsyncTask = GetForecastsAsyncTask(startDate);
            return _getForecastsAsyncTask;
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
                    Forecasts = new List<IWeatherForecastDTO>();
                    _service.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~FetchDataViewModel()
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
