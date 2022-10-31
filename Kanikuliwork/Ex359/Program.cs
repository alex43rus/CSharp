void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 5);
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

int FindPobeditel(int[,] matrix)
{
    int stroka = 0;
    int max = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        stroka = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            stroka = stroka + matrix[i, j];
            if (max < stroka)
                max = stroka;
       
        }
    Console.WriteLine($"Спортсмен {i + 1} получил {stroka} баллов \t");
    }
// int count = max;
// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             if ( count == matrix[i, j])
//                 sum++;
//     }
Console.WriteLine($"Победитель набрал {max} баллов");
return max;
// Console.WriteLine($"Победителей: {sum}");
}

void FindDouble(int[,] matrix)
{
    //int count = FindPobeditel(matrix);
    int max = FindPobeditel(matrix);
    int sum = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if ( matrix[i, j] == max)
                sum++;
                
    //Console.WriteLine(count);
    }
Console.WriteLine($"Победителей: {sum}");
}

Console.Clear();
Console.Write("Введите кол-во спортсменов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во бросков: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Таблица: ");
PrintMatrix(matrix);
//int count = Convert.ToInt32(FindPobeditel(matrix));
FindDouble(matrix);

//Console.WriteLine(FindPobeditel(matrix));
//Console.WriteLine($"Победителей: {FindDouble(matrix)} \t");
//Console.WriteLine(FindDouble(matrix));
