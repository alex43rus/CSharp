// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            // Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
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

static void BubbleSort(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
        for (int j = 0; j < matrix.Length - i - 1; j++)
        {
            if (matrix[j] < matrix[j + 1])
            {
                int temp = matrix[j];
                matrix[j] = matrix[j + 1];
                matrix[j + 1] = temp;
            }
        }
}

void SortMatrix(int[,] matrix)
{
    Console.WriteLine("Сортировка по строкам: ");
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            row[j] = matrix[i, j];
        BubbleSort(row);
        Insert(true, i, row, matrix);
    }
    PrintMatrix(matrix);

    // Console.WriteLine("Сортировка по столбцам: ");
    // int[] col = new int[matrix.GetLength(0)];
    // for (int i = 0; i < matrix.GetLength(1); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(0); j++)
    //         col[j] = matrix[i, j];
    //     BubbleSort(col);
    //     Insert(false, i, col, matrix);
    // }
    // PrintMatrix(matrix);
 }

void Insert(bool isRow, int dim, int[] source, int[,] dest)      //это вспомогательный метод с помощью которого мы меняем 
 {                                                          //значения в стоке или столбце исходного массива на отсортированные значения
     for (int k = 0; k < source.Length; k++)
     {
         if (isRow)
             dest[dim, k] = source[k];
         else
             dest[k, dim] = source[k];
     }
 }

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');   // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
PrintMatrix(matrix);
SortMatrix(matrix);