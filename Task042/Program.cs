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

int[] GenerateArray(int length, int num) // вместо массива можно было использовать строку str = Convert.ToString(Num % 2) + str;
{
    int[] array = new int[length];
    for (int i = length - 1; i >= 0; i--)
    {
        array[i] = num % 2;
        num /= 2;
    }
    return array;
}

// string DecimalToBinary(int someNum)
// {
//     string str = "";
//     do
//     {
//         str = Convert.ToString(someNum % 2) + str;
//         someNum = someNum / 2;
//     } while (someNum != 0);
//     return str;
// }

Console.Clear();
int number = DataEntry("Введите число: ");
//int length = ArrayLength(number);
int[] arr = GenerateArray(ArrayLength(number), number);
Console.WriteLine(String.Join("", arr));