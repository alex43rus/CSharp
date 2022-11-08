// // 47
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int k = new Random().Next(-1, 2);
//             while (k == 0)
//                 k = new Random().Next(-1, 2);
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * k, 3);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// double[,] matrix = new double[n, m];
// InputMatrix(matrix);



// // 50
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int k = new Random().Next(-1, 2);
//             while (k == 0)
//                 k = new Random().Next(-1, 2);
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * k, 3);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);

// double[,] matrix = new double[n, m];
// InputMatrix(matrix);

// Console.WriteLine();
// Console.Write("Введите координаты числа, которого Вы хотите найти: ");
// string[] coord = Console.ReadLine().Split(' ');
// int x = int.Parse(coord[0]) - 1;
// int y = int.Parse(coord[1]) - 1;
// if (x >= 0 && x <= n - 1 && y >= 0 && y <= m - 1)
//     Console.WriteLine($"Результат: {matrix[x, y]}");
// else
//     Console.WriteLine("К сожалению, ничего не найдено");



// // 50
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int k = new Random().Next(-1, 2);
//             while (k == 0)
//                 k = new Random().Next(-1, 2);
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * k, 3);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(double[,] matrix, int x, int y)
// {
//     if (x >= 0 && x <= matrix.GetLength(0) - 1 && y >= 0 && y <= matrix.GetLength(1) - 1)
//         Console.WriteLine($"Результат: {matrix[x, y]}");
//     else
//         Console.WriteLine("К сожалению, ничего не найдено");
// }
// int m = int.Parse(num[1]);

// double[,] matrix = new double[n, m];
// InputMatrix(matrix);

// Console.WriteLine();
// Console.Write("Введите координаты числа, которого Вы хотите найти: ");
// string[] coord = Console.ReadLine().Split(' ');
// int x = int.Parse(coord[0]) - 1;
// int y = int.Parse(coord[1]) - 1;
// ReleaseMatrix(matrix, x, y);



// // 52
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int k = new Random().Next(-1, 2);
//             while (k == 0)
//                 k = new Random().Next(-1, 2);
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * k, 2);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// От Igori Rogojev всем 10:30 AM
// От Денис Макарцев всем 10:30 AM
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         double summa = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             summa = summa + matrix[j, i];
//         }
//         Console.WriteLine($"{i + 1} столбец: {summa / matrix.GetLength(1)}");
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);

// double[,] matrix = new double[n, m];
// InputMatrix(matrix);
// ReleaseMatrix(matrix);


// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

// // 53
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' ');
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// int[,] matrix = new int[n, m];
// Console.WriteLine("Begin: ");
// InputMatrix(matrix);
// Console.WriteLine("Result: ");
// ReleaseMatrix(matrix);



// // 55
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' ');
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// while (n != m)
// {
//     Console.Write("Введите кол-во строк и столбцов(кол-во строк=кол-во столбцов): ");
//     num = Console.ReadLine().Split(' ');
//     n = int.Parse(num[0]);
//     m = int.Parse(num[1]);
// }
// ReleaseMatrix(matrix);


// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// // 57

// bool checkNumberInArray(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (number == array[i])
//             return false;
//     }
//     return true;
// }


// int InputMatrix(int[,] matrix, int[] arrayHelp)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//             if (checkNumberInArray(arrayHelp, matrix[i, j]))
//             {
//                 arrayHelp[k] = matrix[i, j];
//                 k++;
//             }
//         }
//     }
//     return k;
// }
// void ReleaseMatrix(int[,] matrix, int[] array, int counts)
// {
//     int[] arrayHelp = new int[counts + 1];
//     for (int i = 0; i <= counts; i++)
//     {
//         arrayHelp[i] = array[i];
//     }
//     for (int k = 0; k < arrayHelp.Length; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (arrayHelp[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Значение {arrayHelp[k]} встречается {count} раз");
//     }
// }
// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' ');
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// int[,] matrix = new int[n, m];
// int[] arrayHelp = new int[n * m];
// Console.WriteLine("Начальный массив: \n");
// int k = InputMatrix(matrix, arrayHelp);
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[i, j] + " \t");
//     Console.WriteLine();
// }
// ReleaseMatrix(matrix, arrayHelp, k);




// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// // 59
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 6);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     int MinNumbers = matrix[0, 0], minRow = 0, minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (MinNumbers >= matrix[i, j])
//             {
//                 MinNumbers = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i != minRow)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j != minColumn)
//                 Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' ');
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// int[,] matrix = new int[n, m];
// Console.WriteLine("Начальный массив: \n");
// InputMatrix(matrix);
// Console.WriteLine("Конечный массив: \n");
// ReleaseMatrix(matrix);