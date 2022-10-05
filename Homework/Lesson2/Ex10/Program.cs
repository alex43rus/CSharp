// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());

while (n > 100)
{
    n = n / 10;
}

Console.Write($"Второе число {n % 10}");
