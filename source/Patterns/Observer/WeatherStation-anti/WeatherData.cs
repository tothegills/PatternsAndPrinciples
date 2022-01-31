namespace Patterns.Observer.WeatherStation_anti;

public class WeatherData
{
    private readonly CurrentConditionsDisplay currentConditionsDisplay = new();
    private readonly ForecastDisplay forecastDisplay = new();
    private readonly StatisticsDisplay statisticsDisplay = new();
    private float temperature;
    private float humidity;
    private float pressure;

    private void MeasurementsChanged()
    {
        currentConditionsDisplay.Update(temperature, humidity);
        forecastDisplay.Update(pressure);
        statisticsDisplay.Update(temperature);

        currentConditionsDisplay.Display();
        forecastDisplay.Display();
        statisticsDisplay.Display();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}