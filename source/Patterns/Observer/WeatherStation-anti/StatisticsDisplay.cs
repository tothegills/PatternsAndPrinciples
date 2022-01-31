namespace Patterns.Observer.WeatherStation_anti;

public class StatisticsDisplay
{
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum= 0.0f;
    private int numReadings;
    
    public void Update(float temp) {
        tempSum += temp;
        numReadings++;

        if (temp > maxTemp) {
            maxTemp = temp;
        }
 
        if (temp < minTemp) {
            minTemp = temp;
        }

        Display();
    }

    public void Display() => Console.WriteLine($"{tempSum / numReadings} / {minTemp} / {maxTemp}");
}