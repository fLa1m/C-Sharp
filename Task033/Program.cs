// Задайте массив. Напишите программу, кот. определяет, присутствует ли заданное число в массиве.

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максимальное значение интервала: ");
int number = DataEntry("Искомое число в массиве: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
DigitCheck(number, array);

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

void DigitCheck(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine($"Число {num} есть в массиве.");
            break;
        }
        else
        {
            if (i == array.Length - 1 && array[i] != num)
            {
                Console.WriteLine($"Числа {num} нет в массиве.");
            }
        }
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if (i == array.Length - 1)
    //     {
    //         Console.WriteLine($"{array[i]}]");
    //     }
    //     else
    //     {
    //         Console.Write($"{array[i]}, ");
    //     }
    // }
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}