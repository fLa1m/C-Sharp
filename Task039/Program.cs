// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ArrayTurn(int[] array)
{
    int temp = 0;
    int iLast = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++) // условие через if не нужно потому что при нечетной длине массива элемент по середине не нужно менять
        {
            temp = array[i];
            array[i] = array[iLast]; // можно array[array.Length - 1 - i] вместо переменной iLast
            array[iLast] = temp;
            iLast--;
        }
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максимальное значение интервала: ");
int[] array = GenerateArray(length, min, max);
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");
ArrayTurn(array);
Console.WriteLine("Перевернутый массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");

// Второй способ через создание нового массива.