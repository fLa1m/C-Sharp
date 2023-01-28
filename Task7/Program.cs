// Напишите программу, кот. принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.WriteLine("Введите целое число: ");
int Num = int.Parse(Console.ReadLine());
Console.Write("Последняя цифра: "+ Num % 10);