using System;
using ClockAngle.Models;

namespace ClockAngle
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("What is the hour?");
      int hourInput = int.Parse(Console.ReadLine());

      Console.WriteLine("What is the minute?");
      int minuteInput = int.Parse(Console.ReadLine());

      float result = Clock.ReturnDegree(hourInput, minuteInput);
      Console.WriteLine("The degrees between the hour and minute is " + result + " degrees.");
    } 
  }
}