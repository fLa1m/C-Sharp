// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowMethod(int n, int m)
{
    if (m == 0) { return 1; }
    else { return n * PowMethod(n, m - 1); }
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(PowMethod(a, b));