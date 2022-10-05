// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. (Можно воспользоваться нумерацией строк, но необязательно)

Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());


while (n > 1000)
{
    
    n = n / 10;
    
}

if (n < 100)
{
    Console.Write($"В вашем числе {n} нет третьей цифры");
}

else
{
    Console.Write($"Третье число {n % 10}");
}

