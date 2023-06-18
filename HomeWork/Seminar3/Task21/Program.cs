// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве

double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Write("Ведите координату Х1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату X2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Z2: ");
double z2 = double.Parse(Console.ReadLine());

double result = distance(x1, y1, z1, x2, y2, z2);
Console.Write($"Расстояние между точками в 3D пространстве равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");