// Напишите программу, кот. принимает на вход число N и выдает произведение чисел от 1 до N.

int MultiplicationOfNumbers(int Numbers)
{
    int Total = 1;
    for (int i = 1; i <= Numbers; i++)
    {
        Total *= i;
    }
    return Total;
}

Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {Num} = {MultiplicationOfNumbers(Num)}");