// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Задайте число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте степень числа");
int numTwo = Convert.ToInt32(Console.ReadLine());

int PowerNum (int number, int degree)
{
    if ( degree == 0) return 1;
    else return PowerNum(number, degree-1)*number;
}

int result = PowerNum( numOne, numTwo);
Console.WriteLine($"Число {numOne} в степени {numTwo} -> {result}");