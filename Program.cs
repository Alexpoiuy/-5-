//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int m = 3;
int n = 4;
double[,] myArray = new double[m, n];

Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        myArray[i, j] = rand.NextDouble();
        myArray[i, j] = Math.Round(myArray[i, j], 2);
        Console.Write(myArray[i, j] + " ");
    }
    Console.WriteLine();
}
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;
        int n = 4;

        double[,] myArray = new double[m, n];

        Random rand = new Random();
    
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                myArray[i, j] = rand.NextDouble();
            }
        }

        Console.Write("Введите номер строки элемента: ");
        int rowIndex = int.Parse(Console.ReadLine());
        Console.Write("Введите номер столбца элемента: ");
        int colIndex = int.Parse(Console.ReadLine());

        if (rowIndex < 0  rowIndex >= m  colIndex < 0 || colIndex >= n)
        {
            Console.WriteLine("Элемент с такими позициями не существует.");
        }
        else
        {
            Console.WriteLine($"Значение элемента: {myArray[rowIndex, colIndex]}");
        }

        Console.ReadKey();
    }
}
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;
        int n = 4;

        int[,] myArray = new int[m, n];

        Random rand = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                myArray[i, j] = rand.Next(1, 10);
                Console.Write($"{myArray[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += myArray[i, j];
            }
            double average = (double)sum / m;
            Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1}: {average}");
        }

        Console.ReadKey();
    }
}