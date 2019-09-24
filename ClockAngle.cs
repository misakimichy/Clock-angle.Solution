using System;

class Clock
{
  static float returnDegree(int hour, int minute)
  {
    float minuteDegree = minute * 6;
    float hourDegree = Convert.ToSingle(hour * 30 + 0.5 * minute);
    float angle = Math.Abs(minuteDegree - hourDegree);
    if (angle > 180)
    {
      angle = 360 - angle;
    }
    return angle;
  }
  static void Main()
  {
    Console.WriteLine("What is the hour?");
    int hourInput = int.Parse(Console.ReadLine());

    Console.WriteLine("What is the minute?");
    int minuteInput = int.Parse(Console.ReadLine());

    float result = returnDegree(hourInput, minuteInput);
    Console.WriteLine("The degrees between the hour and minute is " + result + " degrees.");
  } 
}