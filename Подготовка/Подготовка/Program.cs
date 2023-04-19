using System;

namespace Подготовка
{
    class Program
    {
        public class Person
        {
            public string name =" ";
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
            public void Input()
            {
                age = Convert.ToInt32(Console.ReadLine());
                name = Convert.ToString(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Input();
            person.Print();
        }
    }
}
