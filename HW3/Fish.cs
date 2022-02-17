using System;

namespace HW3
{
    public class Fish:Animal
    {
        private int _depth = 0;
        private string _sound = "Буль-Буль";

        public Fish(int length, string name, string color)
            :base(length, name, color)
        {
           sound = _sound;
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
            }
        }
    }
}
