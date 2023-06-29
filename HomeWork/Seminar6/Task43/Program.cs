// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введи значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введи значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введи значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введи значение k2: ");
double k2 = double.Parse(Console.ReadLine());

int c1 = -1; // Дополнительные переменные необходимые для рассчета (взяты по умолчанию).
int c2 = -1; // Также могут быть введены от пользователя

// // (x, y) = ((-1)*b2 − (-1)*b1)/(k1*(-1)− k2*(-1)), (b1*k2 − b2*k1)/(k1*b2 − k2*b1))

if (k1 / k2 == b1 / b2)
{
    Console.WriteLine("Прямые совпадают. Точек пересечения нет");
    Environment.Exit(0);
}

if (k1 / c1 == k2 / c2) 
{
    Console.WriteLine("Прямые параллельны. Точек пересечения нет");
    Environment.Exit(0);
}

double x = Math.Round((c1 * b2 - c1 * b1) / (k1 * c2 - k2 * c2), 2);
double y = Math.Round((b1 * k2 - b2 * k1) / (k1 * c2 - k2 * c1), 2);

Console.WriteLine($"Точка пересечения прямых равна ({x}, {y})");
