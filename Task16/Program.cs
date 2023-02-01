// Напишите программу, кот. принимает на вход два числа и проверяет, является ли одно число
// квадратом другого.

Console.Clear();
Console.WriteLine("Введите два числа.");
int Num1 = int.Parse(Console.ReadLine());
int Num2 = int.Parse(Console.ReadLine());

// int BigNum = Num1;
// int SmallNum = 0;

// if (Num2 > BigNum)
// {
//     BigNum = Num2;
//     SmallNum = Num1;
// }
// else
// {
//     SmallNum = Num2;
// }

// Console.WriteLine($"Является ли {BigNum} квадратом {SmallNum}?");

// if (SmallNum * SmallNum == BigNum) Console.WriteLine("Да.");
// else Console.WriteLine("Нет.");

if (Num1 * Num1 == Num2 || Num2 * Num2 == Num1)
{
    Console.WriteLine($"{Num1}, {Num2} -> Да.");
}
else
{
    Console.WriteLine($"{Num1}, {Num2} -> Нет.");
}