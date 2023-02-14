// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int DataEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.Clear();
int number = DataEntry("Введите количество чисел Фибонначи: ");
Console.WriteLine($"{String.Join(" ", Fibonacci(number))}");