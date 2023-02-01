// Напишите программу, кот. выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру.

Console.Clear();
int Num = new Random().Next(10, 100);
int FirstNum = Num / 10;
int SecondNum = Num % 10;

Console.Write($"Наибольшая цифра числа {Num}: ");

if (FirstNum >= SecondNum) Console.WriteLine(FirstNum);
else Console.WriteLine(SecondNum);