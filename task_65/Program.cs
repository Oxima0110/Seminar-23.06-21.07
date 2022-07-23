// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Задайте  первое число");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте  второе число");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (n < m) return;
    NaturalNumber(m, n - 1);
    Console.Write($"{n} ");
}

NaturalNumber(numM, numN);