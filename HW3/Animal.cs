using System;

namespace HW3
{
    public class Animal
    {
        protected int length;
        protected string name;
        protected string color;
        protected string sound = "unknown sound";

        public Animal(int length, string name, string color)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("The length must be > 0");
            }
            this.name = name;
            this.color = color;
        }

        public void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
