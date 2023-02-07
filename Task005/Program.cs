// Напишите программу, кот. на вход принимает одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.
Console.Clear();
Console.WriteLine("Введите целое число: ");
int UserNum = int.Parse(Console.ReadLine());
int Digit = -UserNum;
Console.Write("Интервал: ");

while (Digit <= UserNum)
{
    Console.Write(Digit + " ");
    Digit++;
}