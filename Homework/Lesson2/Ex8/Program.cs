// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
/*
for (int i = 1; i <= N; i++) 
    if (i%2 == 0)
        Console.Write(i + " ");
*/

int i = 1;
while (i <= N)
{
    if (i%2 == 0)
        Console.Write(i + " ");
    i++;
}

