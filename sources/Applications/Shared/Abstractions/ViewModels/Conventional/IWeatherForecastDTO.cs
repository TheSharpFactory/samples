using System;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public interface IWeatherForecastDTO
    {
        DateTime Date { get; set; }
        string Summary { get; set; }
        int TemperatureC { get; set; }
        int TemperatureF { get; }
    }
}