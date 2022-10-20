// Task 40
// Console.Clear();
// // int a = 0;
// // int b = 0;
// // int c = 0;
// Console.Write("Введите первую сторону треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую сторону треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третью сторону треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if ((a >= b + c) || (b >= a + c) || (c >= a + b))
// {
//     Console.Write("Такого треугольника не существует ");
// }
// else 
//     Console.Write("Такой треугольник существует ");


// Task 42

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (n > 0)
// {
//     int x = n % 2;
//     result = Convert.ToString(x) + result; //revers
//     n = n / 2;
// }
// Console.WriteLine(result);


// Тоже самое

// string f(int n)
// {
//     if (n == 0 || n == 1)
//         return $"{n}";
//     return f(n / 2) + $"{n % 2}";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Task 44 Fibonacci

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");
//     int x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }

// 45 task Copy Massive
// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// int[] b = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
//     b[i] = array[i];
    
// b[0] = -10;
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"[{string.Join(", ", b)}]");



