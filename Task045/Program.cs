// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
// копирования. 

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] arr = new int[array.Length];
    int i = 0;
    foreach (int el in array)
    {
        arr[i] = el;
        i++;
    }
    return arr;
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максимальное значение интервала: ");
int[] array = GenerateArray(length, min, max);
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] newArray = CopyArray(array);
Console.WriteLine("Скопированный массив:");
Console.WriteLine($"[{String.Join(", ", newArray)}]");