// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка. 


int GetSum(int a, int b)
{
    int result = a + b;
    return result;
}

void PrintMessageToConsole(string message)
{
    Console.WriteLine(message);
}

PrintMessageToConsole("Hello world");

GetSum(10, 15);


/*Console.Write("Ведите координату Х: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Ведите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.Write("Недопустимые координаты: X и Y != 0");
    Environment.Exit(0); //return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Номер четверти: 1");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Номер четверти: 2");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Номер четверти: 3");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Номер четверти: 4");
}*/

