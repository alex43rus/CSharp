// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите первое число: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("Первое чило больше второго");
else if (a < b)
    Console.WriteLine("Первое чило меньше второго");
else if (a == b)
    Console.WriteLine("Они равны");
