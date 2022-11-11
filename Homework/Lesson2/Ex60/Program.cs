// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(-10, 11);
                Console.WriteLine(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ")");
            }
        }
    }
}
// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             Console.WriteLine(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ")");
//         }
//     }
// }


Console.Clear();
Console.Write("Введите X, Y, Z через пробел: ");
string[] num = Console.ReadLine().Split(' ');
int x = int.Parse(num[0]);
int y = int.Parse(num[1]);
int z = int.Parse(num[2]);
int[,,] matrix = new int[x, y, z];
Console.WriteLine("Матрица: ");
InputMatrix(matrix);
// PrintMatrix(matrix);
