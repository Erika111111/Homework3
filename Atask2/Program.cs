// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistXY(int x1, int y1, int z1, int x2,int y2, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return result;
}

Console.WriteLine($"Расстояние между точками = {DistXY(x1,y1,z1,x2,y2,z2)}");