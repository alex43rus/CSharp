// array
/*
int[] array = new int[8];
// int n = 10;
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);

Console.WriteLine("[" + string.Join(", ", array) + "]"); // Вывод массива в строку через запятую
Console.WriteLine($"[{string.Join(", ", array)}]"); //Интерполяция

*/

// Функции, процедура

// Console.Clear();
// void f(ref int x) // процедура
// {
//     x = x + 10;
// }


// int n = 5;
// Console.WriteLine(n);
// f(ref n);
// Console.WriteLine(n);
// Сколько значений мы передаем, столько мы и принимаем
// Сколько значений мы принимаем, столько мы и передаем

// Функции, процедура

// Console.Clear();
// string f(int a, int b) // функция
// {
//     if (a > b)
//         return ">";
        
//     return "<";
// }

// Console.WriteLine(f(7, 5));  //Комент Ctrl+/

//Console.WriteLine("\t"); //Выстраивает табуляцию

// Console.Clear();
// int n = new Random().Next(10, 100); // ???
// int n1 = n / 10;
// int n2 = n % 10;
// Console.WriteLine($"Сгенерированное число: {n}");

// if (n1 > n2)
//     Console.WriteLine(n1);
// else if (n1 < n2)
//     Console.WriteLine(n2);
// else
//     Console.WriteLine("=");

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int n = new Random().Next(100, 1000);
// Console.WriteLine(n);
// int n1 = n / 100;
// int n2 = n % 10;
// Console.WriteLine(n1 * 10 + n2);

// Console.Clear();
// int n = new Random().Next(100, 1000);
// Console.WriteLine($"{n}\n{n / 100 * 10 + n % 10}"); //Тоже самое

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: "); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите второе число: "); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// if (x1%x2 == 0)
//     Console.WriteLine("Кратные"); 
// else

//         Console.WriteLine($"Некратные, остаток {x1 % x2}");

//&& И
//|| или

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите первое число: "); 
// int l = Convert.ToInt32(Console.ReadLine()); 
 
// if ((l%7 == 0) && (l%23 == 0))
//     Console.WriteLine("Кратны");
// else
//     Console.WriteLine("Некратны");


// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите первое число: "); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите второе число: "); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// if ((x2 == x1 * x1) || (x1 == x2 * x2))
//     Console.WriteLine("Второе число является квадратом первого"); 
// else
//     Console.WriteLine("Второе число не является квадратом первого");


