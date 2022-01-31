using FluentAssertions;
using Xunit;

namespace Patterns.Observer.WeatherStation;

public class WhenDisplaysObserveTheWeather
{
    [Fact]
    public void CouplingIsLoose()
    {
        var currentConditionsDisplay = new CurrentConditionsDisplay();
        var weatherData = new WeatherData(currentConditionsDisplay);
        weatherData.SetMeasurements(22, 83, 1008);
        currentConditionsDisplay.Display().Should().Be("22C 83%");
    }
}