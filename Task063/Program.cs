// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

string Method(int a, int b)
{
    if (a < b) { return $"{a}, " + Method(a + 1, b); }
    else if (a == b) { return $"{a}"; }
    else return String.Empty;
}

Console.Write("Введите конец интервала: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine(Method(i, n));