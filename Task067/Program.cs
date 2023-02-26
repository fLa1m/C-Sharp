// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int n)
{
    if (n == 0) { return 0; }
    else { return n % 10 + SumNumber(n / 10); }
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumber(num));