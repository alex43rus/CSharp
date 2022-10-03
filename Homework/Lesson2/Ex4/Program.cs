// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: "); 
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
    max = b;
else if (max < c)
    max = c;

Console.WriteLine(max);
