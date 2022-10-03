//Максимум из 9 чисел
//Функции

//double f(double x)
//double result = 

//Console.Write("Введите ваше имя:");
//Console.Writeline("0000");
//Console.Write("1111");

int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
array[0] = 12;
Console.Writeline(array[4]);


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.Writeline(result);


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
int [array] = {1, 12, 31, 4, 15, 16, 17, 18};

int n =array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Writeline(index);
    }
    index++;
}
*/
/*
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection
    }
}
int[] array = new int[10];
*/