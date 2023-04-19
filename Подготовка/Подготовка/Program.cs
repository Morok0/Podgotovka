using System;

namespace Подготовка
{
    class Program
    {
        public class Person
        {
            public string name = "Undefined";
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Print();
        }
    }
}
