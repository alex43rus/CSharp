//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ProizMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] ResultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            ResultMatrix[i, j] = matrixOne[i, j] * matrixTwo[i, j];
            Console.Write(ResultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrixOne = new int[n, m];
int[,] matrixTwo = new int[n, m];
Console.WriteLine("Первая матрица: ");
InputMatrix(matrixOne);
Console.WriteLine("Bторая матрица ");
InputMatrix(matrixTwo);
Console.WriteLine("Произведение: ");
ProizMatrix(matrixOne, matrixTwo);
