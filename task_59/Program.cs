// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

int[] ArrMin(int[,] array)
{
    int[] arr = new int[2];
    int min = array[0, 0];
    int lineMin = 0;
    int columnMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                lineMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] { lineMin, columnMin };
}

void PrintMatrixResult(int[,] arr, int[] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != array[0])
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == 0) Console.Write("|");
                if (j != array[1])
                {
                    if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
                    else Console.Write($"{arr[i, j],3} |");
                }
            }
            Console.WriteLine();
        }
    }
}


int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine();
int[] arrMin = ArrMin(arrayResult);
PrintMatrixResult(arrayResult, arrMin);
Console.WriteLine();
Console.WriteLine($"{arrMin[0]}, {arrMin[1]}");

