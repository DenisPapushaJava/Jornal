﻿
namespace Jornal.Clasess
{
    internal class CalculationCoefficient
    {
        static public string CoefficientOfPunch(double punch)
        {
            string kF = "1.0";
            if (punch == 2)
            {
                kF = "1.1";
            }
            if (punch == 3)
            {
                kF = "1.2";
            }
            if (punch == 4)
            {
                kF = "1.3";
            }
            if (punch == 5)
            {
                kF = "1.4";
            }
            if (punch == 6)
            {
                kF = "1.5";
            }

            if (punch == 7)
            {
                kF = "1.6";
            }

            if (punch == 8)
            {
                kF = "1.7";
            }

            if (punch == 9)
            {
                kF = "1.8";
            }

            if (punch == 10)
            {
                kF = "2.0";
            }
            if (punch > 10 && punch <= 15)
            {
                kF = "2.5";
            }
            if (punch > 15 && punch <= 20)
            {
                kF = "3.0";
            }
            if (punch > 20 && punch <= 30)
            {
                kF = "3.5";
            }
            if (punch > 30 && punch <= 40)
            {
                kF = "4.0";
            }
            if (punch > 40 && punch <= 50)
            {
                kF = "4.5";
            }
            if (punch > 50 && punch <= 60)
            {
                kF = "5.0";
            }
            if (punch > 60 && punch <= 70)
            {
                kF = "5.5";
            }
            if (punch > 70 && punch <= 80)
            {
                kF = "6.0";
            }
            if (punch > 80)
            {
                kF = "6.5";
            }
            return kF;
        }
    }
}
