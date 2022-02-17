using System;

namespace HW3
{
    public class Dog:Animal
    {
        private string _sound = "Гав-Гав";

        public Dog(int length, string name, string color)
            : base(length, name, color)
        {
            sound = _sound;
        }
    }
}
