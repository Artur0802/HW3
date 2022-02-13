using System;

namespace HW3
{
    public class Dog:Animal
    {
        private new string _sound = "Гав-Гав";

        public Dog(int length, string name, string color)
            : base(length, name, color)
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
    }
}
