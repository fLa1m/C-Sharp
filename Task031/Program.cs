// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void AmountDigit(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");
}

void ForeachAmountDigit(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    foreach (int i in array)
    {
        if (i > 0)
        {
            sumPositive += i;
        }
        else
        {
            sumNegative += i;
        }
    }
    Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максмальное значение интервала: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
ForeachAmountDigit(array);
AmountDigit(array);