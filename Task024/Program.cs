// Напишите программу, кот. принимает на вход число (А) и выдает сумму чисел от 1 до А.

int GetSumNum(int Num)
{
    int Sum = 0;
    for (int i = 0; i <= Num; i++)
    {
        Sum += i;
    }
    return Sum;
}

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNum(A)}");