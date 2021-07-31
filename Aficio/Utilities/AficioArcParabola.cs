using System;

namespace Aficio
{
    public static class ArcParabola
    {
        // n number of intervals
        public static double GetCurveLength(int n)
        {
            return Math.Round(Math.Sqrt(1 + Math.Pow((2 * n), 2)), 9);
        }
    }
}