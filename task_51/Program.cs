// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    Console.WriteLine($"---------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
        Console.WriteLine($"---------------------");
    }
}

int SumDiagonal(int[,] arr)
{
    int sum = 0;
    int index = 0;
    if (arr.GetLength(0) > arr.GetLength(1)) index = 1;
    {
        for (int i = 0; i < arr.GetLength(index); i++)
        {
            sum = sum + arr[i, i];
        }
    }
    return sum;
}


int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayResult);
int result = SumDiagonal(arrayResult);
Console.Write($" Сумма элементов находящихся на главной диагонали => {result}");