// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int revers = 1;
// for (int i = 1; i <= num; i++)
// {
//     revers = revers*i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {revers}");

int Revers(int number)
{
    int revers = 1;
    for (int i = 1; i <= number; i++)
    {
        revers = revers*i;
    }
    return revers;
}

int result = Revers(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");


