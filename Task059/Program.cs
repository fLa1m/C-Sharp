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

const int row = 0;
const int column = 1;

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

int[] MinPosition(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int[] minPositionInfo = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn]) { minRow = i; minColumn = j; }
        }
    }
    minPositionInfo[row] = minRow;
    minPositionInfo[column] = minColumn;
    return minPositionInfo;
}

int[,] DelRowColumn(int[,] array, int[] infoArray)
{
    int arrRow = array.GetLength(0) - 1;
    int arrColumn = array.GetLength(1) - 1;
    int[,] arr = new int[arrRow, arrColumn];
    int x = 0;
    for (int i = 0; i < arrRow; i++)
    {
        int y = 0;
        for (int j = 0; j < arrColumn; j++)
        {
            if (y == infoArray[column])
            {
                y++;
            }
            if (x == infoArray[row])
            {
                x++;
            }
            arr[i, j] = array[x, y];
            y++;
        }
        x++;
    }
    return arr;
}

int rows = DataInput("Введите количество рядов: ");
int columns = DataInput("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns);
Console.WriteLine();
PrintArray(matrix);
int[] minPos = MinPosition(matrix);
Console.WriteLine();
Console.WriteLine($"Первое минимальное число: ряд {minPos[row] + 1}, столбец {minPos[column] + 1}");
int[,] newArr = DelRowColumn(matrix, minPos);
Console.WriteLine();
PrintArray(newArr);