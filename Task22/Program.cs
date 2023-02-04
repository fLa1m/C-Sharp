// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Count = 1;

while (Count <= Math.Abs(N))
{
    if (Count == N)
    {
        Console.Write($"{Math.Pow(Count, 2)}.");
    }
    else
    {
        Console.Write($"{Math.Pow(Count, 2)}, ");
    }
    Count++;
}