//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");

while (days < 1 || days > 7) 
{
    Console.Write("Неверно, введите номер дня недели снова: ");
    int days = Convert.ToInt32(Console.ReadLine());
}

if (days == 1) 
    Console.Write("Понедельник ");

else if (days == 2) 
    Console.Write("Вторник ");

else if (days == 3) 
    Console.Write("Среда ");

else if (days == 4) 
    Console.Write("Четверг ");

else if (days == 5) 
    Console.Write("Пятница ");

else if (days == 6) 
    Console.Write("Суббота ");

else if (days == 7) 
    Console.Write("Воскресенье ");


if (days == 6 || days == 7) 
    Console.Write("Сегодня у вас выходной");