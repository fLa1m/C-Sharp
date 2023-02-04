// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.

Console.Clear();
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int Ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int Yb = int.Parse(Console.ReadLine());

double Dist = Math.Round((Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2))), 2);

Console.WriteLine("Расстояние равно: " + Dist);