// // 63 task


// string ResultNumbers(int n)
// {
//     if (n == 1)
//         return "1";
//     return ResultNumbers(n - 1) + ", " + Convert.ToString(n);
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(n));

// 63 task


// void ResultNumbers(int n, int j)
// {
//     if (n == j)
//         Console.Write($" {n} ");
//     else
//     {
//         Console.Write($" {j} ");
//         ResultNumbers(n, ++j);
//     }
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), j = 1;
// ResultNumbers(n, j);


// // 65 task
// string ResultNumbers(int m, int n)
// {
//     if (n == m)
//         return $"{m}";
//     return ResultNumbers(m, n - 1) + ", " + Convert.ToString(n);
// }

// Console.Clear();
// Console.Write("Введите число 1-ое: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2-ое: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(m, n));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int ResultNumbers(int n)
// {
//     if (n / 10 == 0)
//         return n;
//     return ResultNumbers(n / 10) + n % 10;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(n));



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int ResultNumbers(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     return ResultNumbers(a, b - 1) * a;
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(a, b));

