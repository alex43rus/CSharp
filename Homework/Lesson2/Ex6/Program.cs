// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x%2 == 0)
    Console.Write("Это четное число ");

else if (x%2 == 1)
    Console.Write("Это число не является четным ");

    