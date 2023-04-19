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
        public class ArreyM
        {
            /*
            internal class Program
            {
                static void Main(string[] args)
                {
                    int colCount = 6;//m
                    int rowCount = 5;//n
                    int[,] arr = GenerateArray(rowCount, colCount);
                    Console.WriteLine("Исходный массив");
                    PrintArray(arr);
                    Console.WriteLine("Сортировка по строкам: ");
                    int[] row = new int[colCount];
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                            row[j] = arr[i, j];
                        BubbleSort(row);
                        Insert(true, i, row, arr);
                    }
                    PrintArray(arr);
                    Console.WriteLine("Сортировка по столбцам: ");
                    int[] col = new int[rowCount];
                    for (int i = 0; i < colCount; i++)
                    {
                        for (int j = 0; j < rowCount; j++)
                            col[j] = arr[j, i];
                        BubbleSort(col);
                        Insert(false, i, col, arr);
                    }
                    PrintArray(arr);
                }
                public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
                {
                    for (int k = 0; k < source.Length; k++)
                    {
                        if (isRow)
                            dest[dim, k] = source[k];
                        else
                            dest[k, dim] = source[k];
                    }
                }
                public static int[,] GenerateArray(int t, int i)
                {
                    int[,] table = new int[t, i];
                    Random random = new Random();
                    for (int a = 0; a < t; a++)
                    {
                        for (int b = 0; b < i; b++)
                        {
                            table[a, b] = random.Next(0, 9);
                        }
                    }
                    return table;
                }
                public static void PrintArray(int[,] array)
                {
                    for (int a = 0; a < array.GetLength(0); a++)
                    {
                        for (int b = 0; b < array.GetLength(1); b++)
                        {
                            Console.Write(array[a, b] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                static void BubbleSort(int[] inArray)
                {
                    for (int i = 0; i < inArray.Length; i++)
                        for (int j = 0; j < inArray.Length - i - 1; j++)
                        {
                            if (inArray[j] > inArray[j + 1])
                            {
                                int temp = inArray[j];
                                inArray[j] = inArray[j + 1];
                                inArray[j + 1] = temp;
                            }
                        }
                }
            }*/
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
            // Работа с двумерным массивом 
            Console.Write("Столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x, y];
            Console.WriteLine();

            Console.WriteLine("Заполни матрицу");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
