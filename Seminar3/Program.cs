// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
    Console.Write("Введите координату х: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Введите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");


// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

while (x < 1 & x > 4)
{
    Console.Write("Неверно, введите номер четверти от 1 до 4: ");
    int x = Convert.ToInt32(Console.ReadLine());
}
if (x == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (x == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (x == 3)
    Console.WriteLine("x < 0 and y < 0");
else
    Console.WriteLine("x > 0 and y < 0");

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.


Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), 3));


// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    i = i * i;
     Console.Write($"{i * i} ");

}
//Console.Write(i);


