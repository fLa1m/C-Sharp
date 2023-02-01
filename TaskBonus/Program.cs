// Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, 
// программа должна выводить слово «Fizz», а вместо чисел, кратных пяти — слово «Buzz». 
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();
int Num = 1;

while (Num <= 100)
{
    if (Num % 3 == 0 && Num % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("FizzBuzz, ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (Num % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Fizz, ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (Num % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Buzz, ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.Write($"{Num}, ");
    }
    Num++;
}