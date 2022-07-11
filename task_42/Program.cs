// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());

int TenToTwo(int n)
{
    if (n == 1) return 1;
    if (n == 0) return 0;
    return n % 2 + 10 * TenToTwo(n / 2);
}

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы счисления: ");
// int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
//     result = result + number % baseNum * d10;
//     number = number / baseNum;
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);



// int a = 13;
// void ToBin(int n)
// {
//     if (n == 0) return;
//     ToBin(n / 2);
//     Console.Write(n % 2);
// }
// ToBin(a);

