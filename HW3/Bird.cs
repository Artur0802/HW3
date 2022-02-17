using System;

namespace HW3
{
    public class Bird:Animal
    {
        private int _tailLength;
        private string _sound = "Чирик-Чирик";

        public Bird(int length, string name, string color, int tailLength)
            : base(length, name, color)
        {
            if (tailLength >= 0)
            {
                _tailLength = tailLength;
            }
            else
            {
                Console.WriteLine("Длина хвоста должна быть >= 0");
                Console.ReadLine();
            }

            sound = _sound;
        }

        public void Fly(int distance)
        {
            if (distance > 0)
            {
                Console.WriteLine("Птица пролетела {0} единиц", distance);
            }
            else
            {
                Console.WriteLine("Дистанция полета должна быть > 0");
            }
        }
    }
}
