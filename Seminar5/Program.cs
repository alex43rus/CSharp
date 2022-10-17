// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// int SummaPositiveNumbers(int[] array)
// {
//    int summaP = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0)
//          summaP = summaP + array[i]; // summaP += array[i];
//    }

//    return summaP;
// }


// int SummaNegativeNumbers(int[] array)
// {
//    int summaN = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] < 0)
//          summaN = summaN + array[i]; // summaP += array[i];
//    }

//    return summaN;
// }


// Console.Clear();
// int[] array = new int[12];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных элементов равна: {SummaNegativeNumbers(array)}");

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.


// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// void ReleaseArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = array[i] * (-1);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next();
// }

// int Proverka(int[] array)
// {
//    int m = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] == m)
//         Console.Write("Ваше число есть в данном массиве");

//      else Console.Write("Вашего числа нет в данном массиве");
//      break;
//    }

//    return m;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// Console.Write("Введите искомое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// Proverka(array);


//Тоже самое
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// string ReleaseArray(int[] array, int number)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] == number)
//          return "yes";
//    }
//    return "no";
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы хотите найти: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{ReleaseArray(array, m)}");


// Задача 35: Задайте одномерный массив из 123 случайных чисел из промежутка [-100, 100]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123



// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-100, 100);
// }


// int ReleaseArray(int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] >= 10 && array[i] <= 99)
//          count++; // count = count + 1
//    }
//    return count;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// Console.Write(ReleaseArray(array));

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(1, 6);
// }


// void ReleaseArray(int[] array)
// {
//    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//    {
//       Console.Write($"{array[i] * array[array.Length - i - 1]} ");
//    }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);


