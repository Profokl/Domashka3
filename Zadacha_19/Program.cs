﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);

if (isNumberA != true)
{
    Console.WriteLine("В числе содержатcя недопустимые символы.Попробуйте заново.");
    return;
}

bool CheckAmount(int b)
{
    if (b >= 10000 && b <= 99999)
    {
        return true;
    }
    return false;
}
bool isCheck = CheckAmount(a);
if (isCheck == false)
{
    Console.WriteLine("Попробуйте ввести пятизначное число");
    return;
}

string str = a.ToString();
int[] array = new int[str.Length];

void FillArray(int[] col)
{
    int count = 0;
    while (count < str.Length)
    {
        col[count] = Convert.ToInt32(str[count].ToString());
        count++;

    }
}
int CompareNumbers(int[] Arr)
{
    int index = 0;
    int index1 = 4;
    int comp = -1;
    while (index < Arr[2])
    {
        if (Arr[index] == Arr[index1])
        {
            comp = 0;
        }
        else
        {
            comp = 1;
            break;
        }
        index++;
        index1--;
    }
    return comp;
}
FillArray(array);
CompareNumbers(array);

void Print(int[] arr)
{
    if (CompareNumbers(array) == 0)
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}
Print(array);