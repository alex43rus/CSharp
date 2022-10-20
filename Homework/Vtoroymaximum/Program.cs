// second Max

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int firstMax = n, secondMax = -1;

// while (n != 0)
// {
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n > firstMax)
//     {
//         secondMax = firstMax;
//         firstMax = n;
//     }
//     else if (n > secondMax)
//         secondMax = n;
// }
// Console.WriteLine(secondMax);


// Задача разница мин и макс

// Console.Clear();

// void fillArray(double[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(new Random().NextDouble() * 10, 3);
//     }
// }

// void findMax (double [] array, ref double nMax)
// {
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i]>nMax)
//         nMax = array[i];
//     }
// }

// void findMin (double [] array, ref double nMin)
// {
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i]<nMin)
//         nMin = array [i];
//     }
// }

// double [] array = new double [5];
// fillArray(array);
// Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
// double nMax = array[0];
// double nMin = array[0];
// findMax(array, ref nMax);
// findMin(array, ref nMin);
// Console.WriteLine($"Разница между {nMax} и {nMin} = {nMax-nMin}");

// SuperStep

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// int[] arrayResult = new int[n];
// int k = Convert.ToInt32(Console.ReadLine());
// k = k % n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         arrayResult[i] = array[n - k + i];
//     for (int i = 0; i < n - k; i++)
//         arrayResult[k + i] = array[i];
    
//     Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }
// else
// {
//     k = k * (-1);
//     for (int i = 0; i < k; i++)
//         arrayResult[n - k + i] = array[i];
//     for (int i = 0; i < n - k; i++)
//         arrayResult[i] = array[k + i];
    
//     Console.WriteLine($"[{string.Join(", ", arrayResult)}]");



// 39 task

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10);
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// 40 task


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

