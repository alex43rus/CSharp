// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            // Console.Write($"{matrix[i, j]} \t");
        }
        //Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
    }
}

// int SumRow(int[] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.Length; i++)
//         for (int j = 0; j < matrix.Length; j++)
//         {
//             sum = sum + matrix[j];
//         }
// Console.WriteLine(sum);
// return sum;
// }

void CompareRow(int[,] matrix)
{
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
            int min = summa;
        }
    Console.WriteLine($"Сумма элементов строки {j + 1}: {summa} \t");
    int min = summa;
    }
Console.Write($"Минимальное значение суммы элементов строки: {min} ");
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');   // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Наш массив: \n");
InputMatrix(matrix);
PrintMatrix(matrix);
CompareRow(matrix);