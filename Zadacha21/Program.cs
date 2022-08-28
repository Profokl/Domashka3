Console.WriteLine ("введите координаты первого числа:");
// int ax = Convert.ToInt32(Console.ReadLine());
// int ay = Convert.ToInt32(Console.ReadLine());
// int az = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("введите координаты второго числа:");
// int bx = Convert.ToInt32(Console.ReadLine());
// int by = Convert.ToInt32(Console.ReadLine());
// int bz = Convert.ToInt32(Console.ReadLine());
bool isNumberAX = int.TryParse(Console.ReadLine(), out int ax);
bool isNumberAY = int.TryParse(Console.ReadLine(), out int ay);
bool isNumberAZ = int.TryParse(Console.ReadLine(), out int az);
Console.WriteLine ("введите координаты второго числа:");
bool isNumberBX = int.TryParse(Console.ReadLine(), out int bx);
bool isNumberBY = int.TryParse(Console.ReadLine(), out int by);
bool isNumberBZ = int.TryParse(Console.ReadLine(), out int bz);

if (!isNumberAX||!isNumberAY||!isNumberAZ||!isNumberBX||!isNumberBY||!isNumberBZ)
{
    Console.WriteLine("В данных содержатcя недопустимые символы.Попробуйте заново.");
}


double GetDistance (int x, int y, int z, int v, int k, int n)
{
    double result = Math.Sqrt (Math.Pow((v-x),2)+Math.Pow((k-y),2)+Math.Pow((n-z),2));
    return result;
}

double res = GetDistance (ax,ay,az,bx,by,bz);
Console.WriteLine (res);