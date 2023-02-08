// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        if (i == col.Length - 1)
        {
            Console.Write($"{col[i]}]");
        }
        else
        {
            Console.Write($"{col[i]},");
        }
    }
}

void ArrayAddition(int[] array1, int[] array2)
{
    int[] add_array = new int[array1.Length + array2.Length];
    for (int i = 0; i < add_array.Length; i++)
    {
        if (i < array1.Length)
        {
            add_array[i] = array1[i];
        }
        else
        {
            add_array[i] = array2[i - array1.Length];
        }
    }
    PrintArray(add_array);
}

void SumArray(int[] array1, int[] array2)
{
    int[] sum_array = new int[array1.Length];
    for (int i = 0; i < sum_array.Length; i++)
    {
        sum_array[i] = array1[i] + array2[i];
    }
    PrintArray(sum_array);
}

Console.Clear();
int[] arr = new int[8];
int[] arr1 = new int[8];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();
SumArray(arr, arr1);
Console.WriteLine();
ArrayAddition(arr, arr1);
