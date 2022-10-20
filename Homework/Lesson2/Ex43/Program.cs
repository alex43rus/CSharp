// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = Math.Abs(Math.Round((b2 - b1) / (k1 - k2), 3));
double y = Math.Round((Math.Abs(k1 * x + b1)), 3);
Console.Write($"Точки пересечения x = {x} и y = {y} ");

