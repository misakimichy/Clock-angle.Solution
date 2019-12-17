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

      Clock inputDegree = new Clock();
      float result = inputDegree.CalcDegree(hourInput, minuteInput);
      Console.WriteLine($"The degrees between hour and minute hands is {result} degrees.");
    } 
  }
}