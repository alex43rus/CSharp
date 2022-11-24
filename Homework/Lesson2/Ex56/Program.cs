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

void CompareRow(int[,] matrix)
{
    int[] SumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow[i] += matrix[i, j];
        }
    }
    int min = SumRow[0];
    int NumberRow = 0;
    for (int i = 0; i < SumRow.Length; i++)
    {
        if (SumRow[i] < min)
            min = SumRow[i];
            NumberRow = i + 1;
    }
Console.Write($"Минимальное значение суммы элементов строки {NumberRow}: {min} ");
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов через пробел: ");
string[] num = Console.ReadLine().Split(' ');   // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Наш массив: \n");
InputMatrix(matrix);
PrintMatrix(matrix);
CompareRow(matrix);