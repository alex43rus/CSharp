// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
while (chislo < 9999 || chislo > 99999)
{
    Console.Write("Неправильно, введите пятизначное число: ");
    chislo = Convert.ToInt32(Console.ReadLine());
} 

int temp = chislo;
int [] revers = new int[5];

for (int i = 0; i < 5; i++)
{
    revers [i] = temp % 10;
    temp /= 10;
}  

int result = 0;
for (int i = 0; i < 5; i++)
{
    int index = 5 - i - 1;
    result += ((int)Math.Pow(10, index)) * revers[i];
}
Console.WriteLine("[" + string.Join(", ", revers) + "]");
Console.WriteLine(result);
Console.WriteLine(chislo);
if (chislo == result)
    Console.WriteLine("Данное число является палиндромом");
else Console.WriteLine("Данное число не является палиндромом");
