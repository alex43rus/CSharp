// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(100, 999);
}

int Chetnyi(int[] array)
{
   int m = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
        
        m++;
        
               
    //   if (m == 0)
      
    //     Console.Write("В массиве нет четных. ");
        
      
   }
   if (m == 0)
      
        Console.Write("В массиве нет четных. ");

   return m;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");

Console.Write($"Количество четных элементов в массиве: {Chetnyi(array)}");

