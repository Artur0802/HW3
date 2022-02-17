using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    public class HW5Methods
    {
        public void Print1To100()
        {
            for (int i = 1; i <= 100; i++)
            {
                double divide3Remainder = Math.IEEERemainder(i, 3);
                double divide5Remainder = Math.IEEERemainder(i, 5);

                if (divide3Remainder == 0 && divide5Remainder != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divide3Remainder != 0 && divide5Remainder == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (divide3Remainder == 0 && divide5Remainder == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }

        public void SumAllEvenValues(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (Math.IEEERemainder(item, 2) == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }

        public void FindMinValueOddIndex(int[] numbers)
        {
            int min = numbers[1];
            for (int i = 3; i < numbers.Length; i = i + 2)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
        }

        public void PrintStringByChars(string text)
        {
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }

    }
}
