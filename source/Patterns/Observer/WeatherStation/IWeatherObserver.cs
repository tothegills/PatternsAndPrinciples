namespace Patterns.Observer.WeatherStation;

public interface IWeatherObserver
{
    void Update(IWeatherData data);
}