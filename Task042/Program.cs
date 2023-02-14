// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int DataEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int ArrayLength(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 2;
        count++;
    }
    return count;
}

int[] GenerateArray(int length, int num)
{
    int[] array = new int[length];
    for (int i = length - 1; i >= 0; i--) 
    {
        array[i] = num % 2;
        num /= 2;
    }
    return array;
}

Console.Clear();
int number = DataEntry("Введите число: ");
//int length = ArrayLength(number);
int [] arr = GenerateArray(ArrayLength(number), number);
Console.WriteLine(String.Join("", arr));