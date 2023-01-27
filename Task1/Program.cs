// Напишите программу, кот. на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Является ли первое число квадратом второго?");

if (num1 == num2 * num2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}