// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// void Array (int[] collection)
// {
//     int i = 0;
//     while (i < collection.Length)
//     {
//         collection[i] = new Random().Next(0, 2);
//         i++;
// }
// }

// void Print (int[] collection)
// {
//     int i = 0;
// Console.Write("[ ");
//     while (i < collection.Length)
//     {
//         Console.Write($"{collection[i]} ");
//         i++;
// } 
// Console.Write("]");
// }
// Array(array);
// Print(array);


 Console.WriteLine("Введите N: ");
int num = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
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
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("]");
}

int[] arr = FillArray(num);
PrintArray(arr);
