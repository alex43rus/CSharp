﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//n = Math.Abs(n);
int rez = 0;
int temp = 0;

while (n > 0)
{
    temp = n % 10;
    rez = rez + temp;
    n = n / 10;
}


Console.WriteLine(rez);

