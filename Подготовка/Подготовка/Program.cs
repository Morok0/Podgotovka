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
        public class Arrey
        {
            
            public int[] Sort(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }
        }
        static void Main(string[] args)
        {   // работа с классом персон
            //Person person = new Person();
            //person.Input();
            //person.Print();
            //работа с одномерным массивом 
            Arrey array = new Arrey();
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            array.Sort(mas);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }
    }
}
