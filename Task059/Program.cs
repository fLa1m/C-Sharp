// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int[,] MinPosition(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int minNum = array[minRow, minColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn]) { minRow = i; minColumn = j; }
        }
        minNum = array[minRow, minColumn];
    }
    Console.WriteLine($"{minNum}, {minRow}, {minColumn}");

    int[,] newArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < minRow; i++)
    {
        for (int j = 0; j < minColumn; j++)
        {
            newArr[i, j] = array[i, j];
        }
    }
    for (int i = minRow + 1; i < array.GetLength(0); i++)
    {
        for (int j = minColumn + 1; j < array.GetLength(1); j++)
        {
            newArr[i, j] = array[i, j];
        }
    }
    return newArr;
}

int rows = DataInput("Введите количество рядов: ");
int columns = DataInput("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns);
Console.WriteLine();
PrintArray(matrix);
int[,] arr = MinPosition(matrix);
PrintArray(arr);