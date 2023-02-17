// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) { sum += array[i, j]; }
        }
    }
    return sum;
}

Console.Clear();
int m = DataInput("Введите количество строк: ");
int n = DataInput("Введите количество столбцов: ");
int minValue = DataInput("Введите начало интервала: ");
int maxValue = DataInput("Введите конец интервала: ");
int[,] matrix = GenerateArray(m, n, minValue, maxValue);
PrintArray(matrix);
Console.WriteLine($"Сумма элементов главной диагонали = {SumMainDiagonal(matrix)}");