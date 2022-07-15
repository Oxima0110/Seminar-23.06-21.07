// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

// int[,] ReplaceMatrix(int[,] array)
// {
//     int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if ( i == 0 || j ==0) arr[i, j] = array[i, j];
//             else if (i % 2 == 0 && j % 2 == 0) arr[i, j] = array[i, j] * array[i, j];
//             else arr[i, j] = array[i, j];
//         }
//     }
//     return arr;
// }

void ReplaceMatrix(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // if ( i == 0 || j ==0) array[i, j] = array[i, j];
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
            else array[i, j] = array[i, j];
        }
    }
}



int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayResult);
// int[,] arrayNew = ReplaceMatrix(arrayResult);
ReplaceMatrix(arrayResult);
// PrintMatrix(arrayNew);
PrintMatrix(arrayResult);