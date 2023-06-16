// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Ведите номер четверти: ");
int a = int.Parse(Console.ReadLine());

if (a < 1 || a > 4)
{
    Console.Write("Недопустимое значение");
    Environment.Exit(0);
}
 switch (a)
{
     case (1):
        Console.Write("Диапазон значений x > 0 и y > 0");
        break;
    case (2):
        Console.Write("Диапазон значений x < 0 и y > 0");
        break;
    case (3):
        Console.Write("Диапазон значений x < 0 и y < 0");
        break;
    case (4):
        Console.Write("Диапазон значений x > 0 и y < 0");
        break;
}