// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 9);
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

int[,] ChangeRowsToColumns(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}

// Второй вариант без привязки к размерам массива
// int[,] ChangeRowsToColumns(int[,] array) 
// {
//     int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newArray[j, i] = array[i, j];
//         }
//     }
//     return newArray;
// }

bool TryChange(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1)) { return true; }
    else { return false; }
}

int[,] matrix = FillArray(4, 3);
PrintArray(matrix);
Console.WriteLine();
if (TryChange(matrix))
{
    int[,] changeMatrix = ChangeRowsToColumns(matrix);
    PrintArray(changeMatrix);
}
else { Console.WriteLine("Обмен рядов и строк невозможен."); }