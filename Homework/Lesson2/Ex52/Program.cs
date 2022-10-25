// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
    }
}

void SredneeArifm(int[,] matrix)
{
    double summa = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa = summa + Convert.ToDouble(matrix[i, j]);
            
        }
    summa = Math.Round(summa / (matrix.GetLength(1) - 1), 1);
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {summa} \t");
    }
    
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
SredneeArifm(matrix);

