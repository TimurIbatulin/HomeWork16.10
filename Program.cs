// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// int NSearch(int N)
// {
//     if (N==1) return 1;
//     Console.Write($"{N}, ");
//    return NSearch(N-1);
// }

// int x=NSearch(10);
// Console.Write(x);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (m-n==0) return n;
    if (m-n<0)
    {
        return m+Sum(m+1,n);
    }
    else
    {
        return n+Sum(m, n+1);
    }
}
Console.Write("Введите первое число диапазона - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число диапазона - ");
int b = Convert.ToInt32(Console.ReadLine());
int x=Sum(a, b);
Console.Write(x);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// static int A(int n, int m)
// {
//     if (n == 0) return m + 1;
//     if (n != 0 && m == 0) return A(n - 1, 1);
//     if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
//     return A(n,m);
// }
// int z=A(0,2);
// Console.Write(z);