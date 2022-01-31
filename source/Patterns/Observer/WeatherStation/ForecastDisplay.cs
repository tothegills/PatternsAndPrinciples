namespace Patterns.Observer.WeatherStation;

public class ForecastDisplay : IWeatherObserver, IDisplayElement
{
    private float lastPressure;
    private float currentPressure;
    public void Update(IWeatherData data)
    {
        lastPressure = currentPressure;
        currentPressure = data.Pressure;
    }

    public string Display()
    {
        if (Math.Abs(currentPressure - lastPressure) < 0.01)
        {
            return "More of the same";
        }

        return currentPressure > lastPressure
            ? "Improving weather on the way!"
            : "Watch out for cooler, rainy weather";
    }
}