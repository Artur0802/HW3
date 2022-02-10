using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    class Person
    {
        private string name = "Name";
        private string surname = "Surname";
        private int age = 20;

        public Person() { }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine("Мне {0} лет, меня зовут {1} {2}.", age, name, surname);
        }
    }
}
