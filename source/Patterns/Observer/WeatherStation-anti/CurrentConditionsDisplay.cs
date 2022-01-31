namespace Patterns.Observer.WeatherStation_anti;

public class CurrentConditionsDisplay
{
    private float temperature;
    private float humidity;
    
    public void Update(float temperature, float humidity)
    {
        this.temperature = temperature;
        this.humidity = humidity;
    }

    public void Display() => Console.WriteLine($"{temperature}C {humidity}%");
}