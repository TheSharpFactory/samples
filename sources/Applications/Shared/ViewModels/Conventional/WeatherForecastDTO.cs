using System;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class WeatherForecastDTO
        : IWeatherForecastDTO
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF
            => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; } = "";
    }
}
