// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.WriteLine("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else  Console.WriteLine("Введены некорректные координаты");

string Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}

// string Quarter(int x, int y)
// {
//     switch ((x, y))
//     {
//         case ( > 0, > 0):
//             return "Первая четверь";
//         case ( < 0, > 0):
//             return "Вторая четверь";
//         case ( < 0, < 0):
//             return "Третья четверь";
//         case ( > 0, < 0):
//             return "Четвёртая четверь";
//         default:
//             return "Введены некорректные координаты";
//     }
// }

string result = Quater(x, y);
Console.WriteLine(result);
