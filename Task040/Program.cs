// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

int DataEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

bool TringleTeory(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Clear();
int AB = DataEntry("Длина стороны AB: ");
int BC = DataEntry("Длина стороны BC: ");
int AC = DataEntry("Длина стороны AC: ");
if(TringleTeory(AB, BC, AC))
{
    Console.WriteLine("Треугольник существует.");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}