// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрека 100 - 999 => {rndNum}");
int NewNum(int num)
{
    int firstNum = num / 100;
    int secondNum = num % 10;
    return firstNum * 10 + secondNum;
}
int result = NewNum(rndNum);
Console.WriteLine($"Получившееся двузначное число => {result}");