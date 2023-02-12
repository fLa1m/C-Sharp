// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int[] MultiArray(int[] array)
{
    double multLenth = Math.Round(array.Length / 2.0, 0, MidpointRounding.AwayFromZero); // определил длину массива в который будем записывать результат перемножения
    int[] multArr = new int[(int)multLenth]; // сменил тип данных с double на int и создал пустой массив
    int iLast = array.Length - 1; // счетчик для последнего индекса
    for (int i = 0; i < multArr.Length; i++)
    {
        if (i == iLast) // если дошли до середины массива, перемножение не делаем
        {
            multArr[i] = array[i];
        }
        else
        {
            multArr[i] = array[i] * array[iLast];
        }
        iLast--;
    }
    return multArr;
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максимальное значение интервала: ");
int[] array = GenerateArray(length, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int[] multArray = MultiArray(array);
Console.WriteLine("Произведение пар чисел исходного массива:");
PrintArray(multArray);