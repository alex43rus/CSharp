new Random().Next(2, 99);
Console.Write("Введите ваше имя:");
string username = Console.ReadLine();

if (username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же САША");
}
Console.Write("Привет, ");
Console.WriteLine("username");

int numberA = new Random().Next(2, 99);
Console.WriteLine(numberA);
int numberB = new Random().Next(2, 99);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(numberA + numberB);
Console.WriteLine(result);
double numberC = new Random().Next(2, 99);
Console.WriteLine(numberC);
double numberD = new Random().Next(2, 99);
Console.WriteLine(numberD);
Console.WriteLine("Результат деления: ", numberC/numberD);


int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write(max);

//Задача про точки

Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");

int xa = 1, ya = 1, 
    xb = 1, yb = 30;
    xc = 30, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
while(count < 10)
{
    int what = new Random().Next(0, 3);
    if (what == 0)

    if (what == 1)

    if (what == 2)
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count = count + 1;
