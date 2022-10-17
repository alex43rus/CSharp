// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Внутренние функции использовать нельзя(Max и Min)

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(0, 100);
}

int MaxMin(int[] array)
{
   int max = array[0];
   int min = array[0];
   
   int raznost = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > max)
        
        max = array[i];

    if (array[i] < min)
      
        min = array[i];
  
   }
   
   
   raznost = max - min;

   return raznost;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Разцица между максимальным и минимальным элементами в массиве: {MaxMin(array)}");
