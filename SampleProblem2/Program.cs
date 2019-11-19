using System;

namespace SampleProblem2
{
    public class Program
    {
        public static void Main()
        {
            int[] array = {2, 3, 4, 5, 6};
            int gcd = Problem2.GeneralizedGreatestCommonDivisor(array);
            Console.WriteLine($"gcd = {gcd}");

            array = new [] {2, 4, 6, 8, 10};
            gcd = Problem2.GeneralizedGreatestCommonDivisor(array);
            Console.WriteLine($"gcd = {gcd}");
        }
    }
}
