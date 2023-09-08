using WeatherForecastApi.Models;

namespace WeatherForecastApi.Services;

public static class WeatherForecastService
{
    public static List<WeatherForecastDay> GetForecast()
    {
        List<WeatherForecastDay> forecasts = new List<WeatherForecastDay>();
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int highCelsius = random.Next(20, 35); // Random high temperature between 20°C and 35°C
            int lowCelsius = random.Next(-5, 15); // Random low temperature between -5°C and 15°C
            int highFahrenheit = (int)(highCelsius * 1.8 + 32);
            int lowFahrenheit = (int)(lowCelsius * 1.8 + 32);
            WeatherCondition condition = (WeatherCondition)random.Next(1, 14); // Random weather condition

            var forecast = new WeatherForecastDay
            {
                HighCelsius = highCelsius,
                LowCelsius = lowCelsius,
                HighFahrenheit = highFahrenheit,
                LowFahrenheit = lowFahrenheit,
                Condition = condition
            };

            forecasts.Add(forecast);
        }

        return forecasts;
    }
}