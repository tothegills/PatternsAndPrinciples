using System.ComponentModel.DataAnnotations.Schema;

namespace Patterns.Observer.WeatherStation;

public class CurrentConditionsDisplay : IDisplayElement, IWeatherObserver
{
    private float temperature;
    private float humidity;

    public string Display() => $"{temperature}C {humidity}%";

    public void Update(IWeatherData data)
    {
        temperature = data.Temperature;
        humidity = data.Humidity;
    }
}