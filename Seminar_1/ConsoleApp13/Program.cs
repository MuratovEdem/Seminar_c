// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

double ab(double x1, double x2, double y1, double y2)
{ 
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}

Console.Write("Ведите координату Х1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Х2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Y2: ");
double y2 = double.Parse(Console.ReadLine());

double result = ab(x1, x2, y1, y2);
Console.WriteLine($"Расстояниен между координатами {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
