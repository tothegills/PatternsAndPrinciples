namespace Patterns.Observer.WeatherStation;

public class WeatherData : IWeatherData
{
    public float Temperature { get; private set; }
    public float Humidity { get; private set; }
    public float Pressure { get; private set; }
    private readonly List<IWeatherObserver> observers;

    public WeatherData(params IWeatherObserver[] observers)
    {
        this.observers = new List<IWeatherObserver>(observers);
    }

    private void MeasurementsChanged()
    {
        foreach (var observer in observers)
            observer.Update(this);
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}