// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 1; i < n; i++)
{
    Console.Write("Введите число: ");
    m = Convert.ToInt32(Console.ReadLine());
    if (m > 0)
        count++;
}

Console.WriteLine($"{count} чисел больше нуля ");
