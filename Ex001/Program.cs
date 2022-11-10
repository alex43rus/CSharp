// new Random().Next(2, 99);
// Console.Write("Введите ваше имя:");
// string username = Console.ReadLine();

// //Запоминаем конкретное имя

// if (username.ToLower() == "саша")
// {
//     Console.WriteLine("Ура, это же САША");
// }
// Console.Write("Привет, ");
// Console.WriteLine(username);



//Сложение и деление случайных чисел


// int numberA = new Random().Next(2, 99);
// int numberB = new Random().Next(2, 99);
// Console.Write(numberA);
// Console.Write("+");
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.Write("Результат сложения: ");
// Console.WriteLine(result);
// double numberC = new Random().Next(2, 99);
// double numberD = new Random().Next(2, 99);
// Console.Write(numberC);
// Console.WriteLine(numberD);
// double resultdel = numberC / numberD;
// Console.Write("Результат деления: ");
// Console.WriteLine(resultdel);

//Задача про гири

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("Максимальное число: ");
// Console.WriteLine(max);


//Задача про точки

//Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

// int xa = 40, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = ya;
// int count = 0;
// while(count < 10000)
// {
//     int what = new Random().Next(0, 3); //Интервал 0,1,2
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }

//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }

//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count = count + 1; //count++
// }

