// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.

string Method(int a, int b)
{
    if (a <= b) { return $"{a} " + Method(a + 1, b); }
    else return String.Empty;
}

int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int m, n;
do
{
    m = DataInput("Введите начало интервала: ");
    n = DataInput("Введите конец интервала: ");
    if (m > n) { Console.WriteLine("Введите правильный интервал."); }
} while (m > n);
Console.WriteLine(Method(m, n));