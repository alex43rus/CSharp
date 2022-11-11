//Семинар №1

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n * n);
*/

/*
Console.Write("Введите первое число: "); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
if (x2 == x1 * x1)
    Console.WriteLine("Второе число является квадратом первого"); 
else
    Console.WriteLine("Второе число не является квадратом первого");
*/
/*
Console.Write("Введите номер дня недели: ");
while (day < 1 || day > 7) {
    Console.Write("Неверно, введите номер дня недели снова: ");
    int day = Convert.ToInt32(Console.ReadLine());
}

if (day == 1) 
    Console.Write("Понедельник ");

else if (day == 2) 
    Console.Write("Вторник ");

else if (day == 3) 
    Console.Write("Среда ");

else if (day == 4) 
    Console.Write("Четверг ");

else if (day == 5) 
    Console.Write("Пятница ");

else if (day == 6) 
    Console.Write("Суббота ");

else if (day == 7) 
    Console.Write("Воскресенье ");
*/

/*
Console.Write(«Введите число: «);
int n=Convert.ToInt32(Console.ReadLine());
switch (n)
{
case 1: Console.WriteLine(«Понедельник»); break;
case 2: Console.WriteLine(«Вторник»); break;
case 3: Console.WriteLine(«Среда»); break;
case 4: Console.WriteLine(«Четверг»); break;
case 5: Console.WriteLine(«Пятница»); break;
case 6: Console.WriteLine(«Суббота»); break;
case 7: Console.WriteLine(«Воскресенье»); break;
default: Console.WriteLine(«вы ошиблись»); break;
}
*/

//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 

for (int i = (-1) * n; i <= n; i+=2)
    Console.Write(i + " ");
*/

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()); 

// for (int i = (-1) * n; i <= n; i++) // i = i + 1 <=> i++
//     Console.Write(i + " ");

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int i = (-1) * n;
while (i <= n)
{
    Console.Write(i + " ");
    i++;
}

*/

//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8
//Остаток при делении на 10
/*
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(n % 10);
*/

//%2=0 кратное 2
