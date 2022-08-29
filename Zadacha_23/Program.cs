// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN)
{
    Console.WriteLine("Это не число!!!");
}

int[] GetCube(int a)
{
    int i = 0;
    int[] res = new int[a];

    {
    for (i = 1; i <= a; i++)
    {
        res[i-1] = (int)Math.Pow(i, 3);
    }
    }
    return res;
}

void PrintCube(int[] b)
{
    int i = 0;
    int len = b.Length;
    for (i = 0; i < len; i++)
        Console.Write($" {b[i]}, ");
}

GetCube(n);
PrintCube(GetCube(n));

//int index = 0;
// int[] array = new int[10];
//array[index]=new Random().Next(10,100);


// if (n == 0)
// {
    // int[] array = new int[n + 1];

// if (n < 0)
// {
    // int[] array = new int[n * -1];
// }



// int[] GetCube(int[]b,int a)
// {
//     int i = 0;
//     int[]res=new int[b.Length];
//     if (a>0)
//     {
//     for (i = 1; i <= a; i++)
//     {
//         res[i-1] = (int)Math.Pow(i, 3);
//     }
//     }
//     if (a==0)
//     {
//     for (i = 1; i >= a; i++)
//     {
//         res[i-1] = (int)Math.Pow(i, 3);
//     }
//     }
//     if (a<0)
//     {
//     for (i = 1; i >= a; i++)
//     {
//         res[i-1] = (int)Math.Pow(i, 3);
//     }
//     }
//     return res;
// }
// void PrintCube(int[] b)
// {
//     int i = 0;
//     int len = b.Length;
//     for (i = 0; i < len; i++)
//         Console.Write($" {b[i]} ");
// }



