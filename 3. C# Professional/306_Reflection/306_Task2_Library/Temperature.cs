using System;

namespace _306_Task2_Library
{
    public class Temperature
    {
        private readonly double temp = 0;

        public Temperature(double temp)
        {
            this.temp = temp;
        }

        public double ConvertToF()
        {
            double tempF = (temp * 1.8) + 32;
            return tempF;
        }

        public double ConvertToK()
        {
            double tempK = temp + 273;
            return tempK;
        }
    }
}
