using System;

namespace HW3
{
    public class Bird:Animal
    {
        private int _tailLength;
        private new string _sound = "Чирик-Чирик";

        public Bird(int length, string name, string color, int tailLength)
            : base(length, name, color)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("Длина должна быть > 0");
                Console.ReadLine();
            }

            this.name = name;
            this.color = color;

            if (tailLength >= 0)
            {
                _tailLength = tailLength;
            }
            else
            {
                Console.WriteLine("Длина хвоста должна быть >= 0");
                Console.ReadLine();
            }

            base._sound = this._sound;
        }

        public void Fly(int distance)
        {
            if (distance > 0)
            {
                Console.WriteLine("Птица пролетела {0} единиц", distance);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Дистанция полета должна быть > 0");
                Console.ReadLine();
            }
        }
    }
}
