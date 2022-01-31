namespace Patterns.Observer.WeatherStation;

public class StatisticsDisplay : IDisplayElement, IWeatherObserver
{
    private float maxTemp = float.MinValue;
    private float minTemp = float.MaxValue;
    private float tempSum;
    private int numReadings;

    public void Update(IWeatherData weatherData)
    {
        tempSum += weatherData.Temperature;
        numReadings++;

        if (weatherData.Temperature > maxTemp)
        {
            maxTemp = weatherData.Temperature;
        }

        if (weatherData.Temperature < minTemp)
        {
            minTemp = weatherData.Temperature;
        }
    }

    public string Display() => $"{tempSum / numReadings} / {minTemp} / {maxTemp}";
}