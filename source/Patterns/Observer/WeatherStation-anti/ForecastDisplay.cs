namespace Patterns.Observer.WeatherStation_anti;

public class ForecastDisplay
{
    private float lastPressure;
    private float currentPressure;

    public void Update(float pressure)
    {
        lastPressure = currentPressure;
        currentPressure = pressure;
    }

    public void Display()
    {
        if (Math.Abs(currentPressure - lastPressure) < 0.01)
        {
            Console.WriteLine("More of the same");
            return;
        }

        if (currentPressure > lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
            return;
        }

        Console.WriteLine("Watch out for cooler, rainy weather");
    }
}