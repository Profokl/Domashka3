// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое положительное число:");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN)
{
    Console.WriteLine("Число введено не верно");
    return;
}

bool CheckAmount(int b)
{
    if (b >= 1)
    {
        return true;
    }
    return false;
}
bool isCheck = CheckAmount(n);
if (isCheck == false)
{
    Console.WriteLine("Попробуйте ввести целое положительное число");
    return;
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

