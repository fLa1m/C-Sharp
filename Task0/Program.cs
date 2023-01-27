// Напишите программу, которая на вход принимает число и выдает квадрат (число умноженное на само себя).
Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()); // конвертация string в int
int sqre = num * num;
Console.WriteLine("Квадрат числа " + num + " равен " + sqre);