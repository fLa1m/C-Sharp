// Напишите программу, кот. принимает на вход координаты точки (X и Y). Причем обе координаты не равны нулю.
// И выдает номер четверти плоскости в которой они находятся.

Console.Clear();
Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("1я четверть");
else if (X < 0 && Y > 0) Console.WriteLine("2я четверть"); // в данном случае можно без else if, так как нет пересечений условий
else if (X < 0 && Y < 0) Console.WriteLine("3я четверть");
else if (X > 0 && Y < 0) Console.WriteLine("4я четверть");
else Console.WriteLine("Введите отличную от нуля координату");