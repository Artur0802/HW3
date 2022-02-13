using System;

namespace HW3
{
    public class Person
    {
        private string _name = "Имя";
        private string _surname = "Фамилия";
        private int _age = 20;

        public Person() { }

        public Person(string name, string surname, int age)
        {
            if (name.Length > 2)
            {
                _name = name;
                _surname = surname;
            }
            else
            {
                Console.WriteLine("Имя должно быть больше 2 символов");
                Console.ReadLine();
            }

            if (surname.Length > 2)
            {
                _surname = surname;
            }
            else
            {
                Console.WriteLine("Фамилия должна быть больше 2 символов");
                Console.ReadLine();
            }

            if (age > 0 && age <= 120)
            {
                _age = age;
            }
            else
            {
                Console.WriteLine("Возраст должен быть больше 0 и не более 120 лет");
                Console.ReadLine();
            }
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine("Мне {0} лет, меня зовут {1} {2}.", _age, _name, _surname);
            Console.ReadLine();
        }
    }
}
