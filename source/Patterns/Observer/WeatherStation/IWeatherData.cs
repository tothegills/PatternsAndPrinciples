namespace Patterns.Observer.WeatherStation;

public interface IWeatherData
{
    float Temperature { get; }
    float Humidity { get; }
    float Pressure { get; }
}