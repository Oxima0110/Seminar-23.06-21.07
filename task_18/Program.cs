﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1: Console.WriteLine("x > 0 и y > 0"); break;
    case 2: Console.WriteLine("x < 0 и y > 0"); break;
    case 3: Console.WriteLine("x < 0 и y < 0"); break;
    case 4: Console.WriteLine("x > 0 и y < 0"); break;
    default: Console.WriteLine("Нет такой четверти"); break;
}

// string Quarter(int num)
// {
//     case 1: return "x > 0 && y > 0"; 
//     case 2: return "x < 0 && y > 0"; 
//     case 3: return "x < 0 && y < 0"; 
//     case 4: return "x > 0 &&  y < 0";
// return "Нет такой четверти";
// }
