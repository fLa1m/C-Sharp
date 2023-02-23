// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int[,] FillArray(int rows, int columns) // Наполнение массива
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(100, 200);
        }
    }
    return array;
}

void PrintArray(int[,] array) // вывод на печать массива
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

bool Contains(int[] array, int numbers) // проверка на наличие числа в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers) { return true; }
    }
    return false;
}

int[] Resize(int[] someArray, int number) // изменение длины массива и дополнение его новым значением
{
    int[] newArray = new int[someArray.Length + 1];
    for (int i = 0; i < someArray.Length; i++)
    {
        newArray[i] = someArray[i];
    }
    newArray[newArray.Length - 1] = number;
    return newArray;
}

int[] FillUniqArray(int[,] someArray) // создание массива с уникальными значениями для проверки
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

void ComparingArrays(int[,] array, int[] digits) // подсчет и вывод данных
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

void SortingArray(int[] array) // Сортировка массива по возрастанию
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void PrintData(int[] inArray) // вариант преподавателя, предварительно двумерный массив переведен в одномерный и отсортирован по возрастанию
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}

int[,] array = FillArray(3, 3);
PrintArray(array);
Console.WriteLine();
int[] numbersInArray = FillUniqArray(array);
SortingArray(numbersInArray);
ComparingArrays(array, numbersInArray);