// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

bool Contains(int[] array, int numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers) { return true; }
    }
    return false;
}

int[] Resize(int[] someArray, int number)
{
    int[] newArray = new int[someArray.Length + 1];
    for (int i = 0; i < someArray.Length; i++)
    {
        newArray[i] = someArray[i];
    }
    newArray[newArray.Length - 1] = number;
    return newArray;
}

int[] FillUniqArray(int[,] someArray)
{
    int[] uniqArray = new int[0];
    foreach (int el in someArray)
    {
        if (Contains(uniqArray, el) == false)
        {
            uniqArray = Resize(uniqArray, el);
        }
    }
    return uniqArray;
}

void ComparingArrays(int[,] array, int[] digits)
{
    int count = 0;
    foreach (int elDigts in digits)
    {
        foreach (int elArray in array)
        {
            if (elDigts == elArray) { count++; }
        }
        if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4)
        {
            Console.WriteLine($"{elDigts} встречается {count} раза");
        }
        else { Console.WriteLine($"{elDigts} встречается {count} раз"); }
        count = 0;
    }
}

int[,] array = FillArray(3, 3);
PrintArray(array);
Console.WriteLine();
int[] numbersInArray = FillUniqArray(array);
ComparingArrays(array, numbersInArray);