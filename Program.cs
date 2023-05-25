
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

void OtBolKMen(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int g = 0; g < array.GetLength(1) - 1; g++)
            {
                 if(array[i,g] < array[i, g + 1]) 
                 {
                    int temp = array[i, g + 1];
                    array[i, g + 1] = array[i, g];
                    array[i, g] = temp;
                 }
            }
           
        }
    }            
}



Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, columns, minValue, maxValue);
Show2DArray(myArray);
OtBolKMen(myArray);
Show2DArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

void NumberRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0; 
    int sumRow = 0; 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        minRow += array[0, i]; 
    } 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        sumRow += array[i, j]; 
        if (sumRow < minRow) 
        { 
            minRow = sumRow; 
            minSumRow = i; 
        } 
        sumRow = 0; 
        }
        Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, columns, minValue, maxValue);
Show2DArray(myArray);
NumberRow(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

void MultiplyMatrix(int[,] myArray, int[,] myArray2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0; 
            for (int k = 0; k < myArray.GetLength(1); k++) 
            { 
                sum += myArray[i,k] * myArray2[k,j]; 
            }
            resultMatrix[i,j] = sum; 
        } 
    }
}

Console.WriteLine("Введите количество строк 1 матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел 1 матрицы: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел 1 матрицы: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел 2 матрицы: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел 2 матрицы: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, columns, minValue, maxValue);
Show2DArray(myArray);
int[,] myArray2 = CreateRandom2DArray(rows2, columns2, minValue2, maxValue2);
Show2DArray(myArray2);
if (columns != rows2)
{
    Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
}
else
{
    int[,] resultMatrix = new int[rows, columns2];
    MultiplyMatrix(myArray, myArray2, resultMatrix);
    Show2DArray(resultMatrix);
}
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3DArray(int rows, int columns, int three, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, three];
    bool[] usedNumbers = new bool[90]; 
    Random random = new Random();

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < three; k++)
            {
                int number;
                do
                {
                    number = random.Next(minValue, maxValue + 1);
                } 
                while (usedNumbers[number - 10]);
                array[i, j, k] = number;
                usedNumbers[number - 10] = true;
            }
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"array[{i}][{j}][{k}]: {array[i, j, k]}");
                }
            }
        }
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество 3 измерение: ");
int three = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3DArray(rows, columns, three, minValue, maxValue);
Show3DArray(myArray);
*/