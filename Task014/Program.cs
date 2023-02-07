// Напишите программу, кот. принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {Num} кратно 7 и 23?");

if (Num % 7 == 0 && Num % 23 == 0) Console.WriteLine("Да."); // & - проверяет оба операнда; && - если первый false не будет проверять второй;
else Console.WriteLine("Нет.");