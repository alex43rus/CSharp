void OutputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write($"{array[i]}, ");
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
    {
    Console.Write("Неверно, введите положительное кол-во элементов массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
string[] array = new string[n];
Console.Write("Вводите элементы массива через пробел: ");
// for (int i = 0; i <= n; i++)
//     {     
//         array[i] = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
//     }
array = Console.ReadLine().Split(' ').ToArray();

OutputArray(array);