// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] NewArray(int[,] arr)
{
    int[] array = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[k] = arr[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position != count - 1) Console.Write($"{col[position]}, ");
        else Console.Write($"{col[position]}");
        position++;
    }
    Console.Write("]");
}

int[] SummUniqValuesInArray(int[] in_array, int[] in_array2)
{
    int count = 0;
    int actuaiValue = in_array[0];
    int iForSecondArray = 0;
    for (int i = 0; i < in_array.Length; i++)
    {
        if (actuaiValue == in_array[i]) count++;
        else
        {
            actuaiValue = in_array[i];
            in_array2[iForSecondArray] = count;
            count = 1;
            iForSecondArray++;
        }

        if (i == in_array.Length - 1) in_array2[iForSecondArray] = count;
    }
    return in_array2;
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arrayResult);
Console.WriteLine();
int[] newArr = NewArray(arrayResult);
PrintArray(newArr);
Console.WriteLine(" Одномерный массив");
Array.Sort(newArr);
Console.WriteLine();
PrintArray(newArr);
int[] uniqArray = newArr.Distinct().ToArray();
Console.WriteLine(" Отсортированный массив");
Console.WriteLine();
PrintArray(uniqArray);
uniqArray = SummUniqValuesInArray(newArr, uniqArray);
Console.WriteLine(" Числа");
PrintArray(uniqArray);
Console.WriteLine(" Количество повторений");