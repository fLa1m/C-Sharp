// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int Field = int.Parse(Console.ReadLine());

if (Field == 1)
{
    Console.WriteLine("Диапазон координат: x > 0; y > 0");
}
else if (Field == 2)
{
    Console.WriteLine("Диапазон координат: x < 0; y > 0");
}
else if (Field == 3)
{
    Console.WriteLine("Диапазон координат: x < 0; y < 0");
}
else if (Field == 4)
{
    Console.WriteLine("Диапазон координат: x > 0; y < 0");
}
else
{
    Console.WriteLine("Введите номер четверти от 1 до 4");
}