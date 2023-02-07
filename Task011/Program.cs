// Напишите программу, кот. выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();
int Num = new Random().Next(100, 1000);
int FirstNum = Num / 100;
int ThirdNum = Num % 10;
int Result = FirstNum * 10 + ThirdNum;

Console.WriteLine($"{Num}, {Result}");