// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine ("введите координаты первого числа:");
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