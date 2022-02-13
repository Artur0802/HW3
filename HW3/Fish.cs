using System;

namespace HW3
{
    public class Fish:Animal
    {
        private int _depth = 0;
        private new string _sound = "Буль-Буль";

        public Fish(int length, string name, string color)
            :base(length, name, color)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("Длина должна быть > 0");
            }
            this.name = name;
            this.color = color;
            base._sound = this._sound;
        }

        public void Dive(int depth)
        {
            if (depth > 0)
            {
                _depth = _depth + depth;
            }
            else
            {
                Console.WriteLine("Глубина заныривания должна быть > 0");
                Console.ReadLine();
            }
        }
    }
}
