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

void FindMax(int[,] matrix)
{
    int max = matrix[0, 0];
    int maxI = 0;
    int maxJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (max < matrix[i, j])
            {
                max = matrix[i, j];
                maxI = i;
                maxJ = j;
            }
            
        }
    }
    Console.WriteLine($"Максимальный элемент {max} находится в строке № {maxI + 1} и столбце № {maxJ + 1} \t");
}


Console.Clear();
Console.Write("Введите кол-во спортсменов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во бросков: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
FindMax(matrix);

