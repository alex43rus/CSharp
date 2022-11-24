//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ResultNumbers(int a, int b)
{
    if (a == b)
        return a;
    
    return a + ResultNumbers(a + 1, b);
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число не должно быть больше второго");
    Console.Write("Введите 1-ое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-ое число: ");
    b = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(ResultNumbers(a, b));