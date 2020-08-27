using System;

namespace CalculateAngle
{
    class SmartClock
    {
        public double GetAngleBetweenHourAndMinute(int hour,int minute)
        {
            //∆θ=|5(6H-11/10M) |0
            //hour =>H
            //minute=>M
            return Math.Abs(5*((6 * hour)-(1.1*minute)));
        }
    }
}