using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW3
            //int a = -2;
            //int b = -3;
            //PrintMaxSqrt(a, b);            
            //
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("'a' = {0}, 'b' = {1}", a, b);
            #endregion

            var fish = new Fish(2, "Рыба", "Серая");
            var bird = new Bird(2, "Птица", "Разноцветная", 1);
            var dog = new Dog(2, "Собака", "Черная");
            fish.MakeSound();
            bird.MakeSound();
            dog.MakeSound();
            Console.ReadLine();
        }

        #region HW3 methods
        public void PrintSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void PrintMaxSqrt(int a, int b)
        {
            if (a >= 0 && b >= 0 && a != b)
            {
                Console.WriteLine(Math.Sqrt(Math.Max(a, b)));
            }
            else if (a >= 0 && b < 0)
            {
                Console.WriteLine(Math.Sqrt(a));
            }
            else if (a < 0 & b >= 0)
            {
                Console.WriteLine(Math.Sqrt(b));
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine(Math.Sqrt(Math.Min(Math.Abs(a), Math.Abs(b))));
            }
            else
            {
                Console.WriteLine("'a' и 'b' равны");
            }
        }
        #endregion

        public void GetSeason(int monthNumber)
        {
            if (monthNumber > 0 && monthNumber <= 12)
            {
                if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
                {
                    Console.WriteLine("Зима");
                }
                else if (monthNumber >= 3 && monthNumber <= 5)
                {
                    Console.WriteLine("Весна");
                }
                else if (monthNumber >= 6 && monthNumber <= 8)
                {
                    Console.WriteLine("Лето");
                }
                else
                {
                    Console.WriteLine("Осень");
                }
            }
            else
            {
                Console.WriteLine("Введите корректный номер месяца (1-12)");
            }
        }
    }


}
