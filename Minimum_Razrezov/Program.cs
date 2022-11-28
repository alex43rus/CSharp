Console.Clear();
Console.Write("Введите количество человек: ");
int N = Int32.Parse(Console.ReadLine());
int m = 0;
for (m = 0; N > 1; m++)
{
    if (N % 2 == 1)
    {
        N = N - 1;
        m++;
    }
    N = N / 2;
}
Console.WriteLine(m);
