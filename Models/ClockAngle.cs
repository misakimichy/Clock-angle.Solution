using System;

namespace ClockAngle.Models
{
    class Clock
    {
        public int Hour { get ; set; } 
        public int Minute { get ; set; } 

        public Clock (int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public static float ReturnDegree(int hour, int minute)
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
    }
}