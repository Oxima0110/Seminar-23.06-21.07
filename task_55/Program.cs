// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
     Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             arr[i, j] = rnd.Next(0, 10);
            // arr[i, j] = i + j;
        }
    }
    return arr;
}

int[,] ExchangeMatrix(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[j, i] = array[i, j];
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


int[,] arrayResult = CreateMatrixRndInt(3, 3);
PrintMatrix(arrayResult);
Console.WriteLine();
if (arrayResult.GetLength(0) != arrayResult.GetLength(1)) Console.WriteLine("Невозможно заменить строки столбцами.");
else 
{
    
    int[,] resultMatrix = ExchangeMatrix(arrayResult);
    PrintMatrix(resultMatrix);
}