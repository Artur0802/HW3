using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            a = a + b;
            b = a - b;
            a = a - b;
        }

        public void PrintSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void PrintMax(int a, int b)
        {
            Console.WriteLine(Math.Sqrt(Math.Max(a, b)));
        }
    }


}
