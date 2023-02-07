// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.Clear();
Console.Write("Введите первое число: ");
int FirstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNum = int.Parse(Console.ReadLine());

int BigNum = FirstNum;
int SmallNum = 0;

if (SecondNum > BigNum)
{
    BigNum = SecondNum;
    SmallNum = FirstNum;
}
else
{
    SmallNum = SecondNum;
}

int Remainder = BigNum % SmallNum;

if (Remainder == 0)
{
    Console.WriteLine($"{BigNum} кратно {SmallNum}");
}
else
{
    Console.Write($"{BigNum} не кратно {SmallNum}, остаток {Remainder}");
}