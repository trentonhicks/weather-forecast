import WeatherCondition from "./WeatherCondition";

type ForecastDay = {
    highCelsius: number,
    lowCelsius: number,
    lowFahrenheit: number,
    highFahrenheit: number,
    condition: WeatherCondition,
};

export default ForecastDay;