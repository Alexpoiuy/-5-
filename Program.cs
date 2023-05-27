//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNum(int n)
{
    if(n < 0) Console.Write($"{n} не натуральное число ");
    if(n == 0) return;
    Console.Write("{0, 4}", n);
    ShowNum(n - 1);
}

ShowNum(3);
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int M, int N) 
{ 
    if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}

int result = SumNumbers(1, 5);
Console.WriteLine(result);
*/

//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = 2;
int n = 3;

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");
*/
