namespace WeatherForecastApi.Models;

public record WeatherForecastDay
{
    public int HighCelsius { get; init; }
    public int LowCelsius { get; init; }
    public int LowFahrenheit { get; init; }
    public int HighFahrenheit { get; init; }
    public WeatherCondition Condition { get; init; }
}