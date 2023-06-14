// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;

if (n > 0)
{
    while(count != n)
    {
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
    }
}
else
{
    while(count != n)
    {
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count--;
    }
}