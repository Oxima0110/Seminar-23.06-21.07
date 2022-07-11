// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] NewArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for(int i=0; i < arr.Length; i++ )
    {
        newArr[i] = arr[i];
    }
return newArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] array = CreateArrayRndInt(5,1,10);
PrintArray(array);

Console.WriteLine();

int[] newArray = NewArray(array);
PrintArray(newArray);