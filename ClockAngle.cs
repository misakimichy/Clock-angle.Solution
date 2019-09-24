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

  } 
}