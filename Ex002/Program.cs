//Максимум из 9 чисел
//Функции



//double f(double x)
//double result = 

//Console.Write("Введите ваше имя:");
//Console.Writeline("0000");
//Console.Write("1111");
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;
*/
/*
int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
*/
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

//int max = Max(
//  Max(a1, b1, c1),
//  Max(a2, b2, c2),
//  Max(a3, b3, c3));


Console.Writeline(max);
*/

/*
int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
array[0] = 12;
Console.Writeline(array[0]);

int Max(int arg1, int arg2, int arg3)   //Функция нахождения максимального числа
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;                      //Конец функции
}

//int max = Max(                        //Переменная с маленькой буквы, функция с большой
//    Max(array[0], array[1], array[2]),
//    Max(array[3], array[4], array[5]),
//    Max(array[6], array[7], array[8])
//);
//Console.Writeline(max);

*/

/*
int a1 = 11;
int b1 = 11;
int c1 = 11;
int a2 = 11;
int b2 = 11;
int c2 = 11;
int a3 = 11;
int b3 = 11;
int c3 = 11;
*/
/*
int max = a1;
if (b1 > max) max = b1;
int max = a1;
if (b1 > max) max = b1;
int max = a1;
if (b1 > max) max = b1;
int max = a1;
if (b1 > max) max = b1;
*/

/*
int [array] = {1, 12, 31, 4, 15, 16, 17, 18}; //Поиск

int n =array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Writeline(index);
        break;
    }
    index++;
}
*/



/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

void PrintArray(int[] col)
{
    int count = col.Lenght;
    int position = 0;
    while(position < count)
    {
        Console.Writeline(col[position]);
        position++;
    }
}

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Lenght;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            positon = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

*/