// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
using System;

class Program
{
    static int BolseNulya(int[] array, int size)
    {
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        return count;
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(-10, 11);
        }

        Console.Write("Массив: ");
        ShowArray(array);

        int count = BolseNulya(array, size);
        Console.WriteLine($"Количество чисел > нуля - {count}");
    }
}
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение k1: ");
        int k1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение k2: ");
        int k2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());

        double x = (double)(b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}, {y})");
    }

    static double peresechenie(int k1, int b1, int k2, int b2)
    {
        return (double)(b2 - b1) / (k1 - k2);
    }
}