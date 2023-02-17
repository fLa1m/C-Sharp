// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] GenerateArray(int num1, int num2, int minValue, int maxValue)
{
    int[,] array = new int[num1, num2];
    for (int i = 0; i < num1; i++)
    {
        for (int j = 0; j < num2; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) { Console.Write($"{array[i, j]}]"); }
            else { Console.Write($"{array[i, j]}, "); }
        }
        Console.WriteLine();
    }
}

void ChangeBothEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) { array[i, j] *= array[i, j]; }
        }
    }
}

Console.Clear();
int m = DataInput("Введите количество строк: ");
int n = DataInput("Введите количество столбцов: ");
int minValue = DataInput("Введите начало интервала: ");
int maxValue = DataInput("Введите конец интервала: ");
int[,] matrix = GenerateArray(m, n, minValue, maxValue);
PrintArray(matrix);
ChangeBothEvenIndex(matrix);
Console.WriteLine();
PrintArray(matrix);