// Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные и наоборот.

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ChangeSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int count = 0;
    foreach (int i in array)
    {
        if (count == array.Length - 1)
        {
            Console.WriteLine($"{i}]");
        }
        else
        {
            Console.Write($"{i}, ");
        }
        count++;
    }
}

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максмальное значение интервала: ");
int[] arr = GenerateArray(length, min, max);
PrintArray(arr);
ChangeSign(arr);
PrintArray(arr);