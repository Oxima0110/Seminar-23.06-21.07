// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Задайте число");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    if (number / 10 == 0) return number;
    else return number % 10 + SumNumber(number / 10);
}

int result = SumNumber(num);
Console.WriteLine($"Сумма цифр числа {num} -> {result}");
