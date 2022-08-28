Console.WriteLine("Введите пятизначное число:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);

if (isNumberA != true)
{
    Console.WriteLine("В числе содержатcя недопустимые символы.Попробуйте заново.");
}

bool CheckAmount(int b)
{
    if (b < 10000 && b > 99999)
    {
        return false;
    }
    return true;
}
bool isCheck = CheckAmount(a);
if (isCheck == false)
{
    Console.WriteLine("Попробуйте ввести пятизначное число");
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
int compareNumbers(int[] Arr)
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
compareNumbers(array);

void Print(int[] arr)
{
    if (compareNumbers(array) == 0)
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}
Print(array);