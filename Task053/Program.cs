//  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 15);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeFirstAndLastRows(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i, j];
        array[i, j] = array[lastRow, j];
        array[lastRow, j] = temp;
    }
}

int[,] matrix = FillArray(5, 5);
PrintArray(matrix);
ChangeFirstAndLastRows(matrix);
Console.WriteLine();
PrintArray(matrix);