using Xunit;

namespace Patterns.Observer.WeatherStation_anti;

public class WhenTheWeatherUpdates
{
    [Fact]
    public void TheNewWeatherIsDisplayed()
    {
        var weatherData = new WeatherData();
        weatherData.SetMeasurements(12, 63, 1008);
    }
}