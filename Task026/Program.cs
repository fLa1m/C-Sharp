// Напишите программу, кот. принимает на вход число и выдает количество цифр в числе.

int NumberOfDigits(int Number)
{
    int Count = 0;
    while (Number > 0)
    {
        Count++;
        Number /= 10;
    }
    return Count;
}

Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {NumberOfDigits(Num)}");
