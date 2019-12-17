using System;

namespace ClockAngle.Models
{
    public class Clock
    {
        public float ReturnDegree(int hour, int minute)
        {
            float minuteDegree = minute * 6;
            float hourDegree = Convert.ToSingle(0.5 * (hour * 60 + minute));
            float angle = Math.Abs(minuteDegree - hourDegree);
            if (angle > 180) angle = 360 - angle;
            return angle;
        }
    }
}