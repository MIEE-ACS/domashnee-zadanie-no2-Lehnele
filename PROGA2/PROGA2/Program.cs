using System;

namespace PROGA2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Введите значение R: ");
         double R = double.Parse(Console.ReadLine());
        for (double x = -7; x <= 11;  x = Math.Round(x, 1) + 0.2)
            {
                Console.WriteLine($"При x={Math.Round(x, 1)}  y ={WhatIsFunction(x, R)}") ; 
            }

        }
        public static double GetYFromFirstSegment(double x)
        {
            double y = 3;
            return y;
        }
        public static double GetYFromTwoSegment(double x, double R)
        {
            double y = Math.Round(-Math.Sqrt(R * R - x * x) + 3, 1);
            return y;
        }
        public static double GetYFromThreeSegment(double x, double R)
        {
            double y = Math.Round(-Math.Sqrt(R * R - x * x) + 3, 1);
            return y;
        }
        public static double GetYFromFourSegment(double x)
        {
            double y = Math.Round(-2 * x + 9, 1);
            return y;
        }
        public static double GetYFromFiveSegment(double x)
        {
            double y = Math.Round(x - 9, 1);
            return y;
        }

        public static double WhatIsFunction(double x, double R)
        {
            if(x >= -7 && x <= -3)
            {
                double y = GetYFromFirstSegment(x);
                return y;
            }
            else if (x >= -3 && x <= 0)
            {
                double y = GetYFromTwoSegment(x, R);
                return y;
            }
            else if (x >= 0 && x <= 3)
            {
                double y = GetYFromThreeSegment(x, R);
                return y;
            }
            else if (x >= 3 && x <= 6)
            {
                double y = GetYFromFourSegment(x);
                return y;
            }
            else if (x >= 6 && x <= 11)
            {
                double y = GetYFromFiveSegment(x);
                return y;
            }
            else
            {
                Console.WriteLine("X находится за пределами массива.");
                return x;
            }
        }
    }
}
