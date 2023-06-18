// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int two_number(int number)
{
    int a = number / 10;
    int result = a % 10;
    return result;
}


Console.Write("Ведите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (99 > number || number > 1000)
{
    Console.Write("Ведено число не входящее в диапазон");
    Environment.Exit(0);
}
int result = two_number(number);
Console.WriteLine($"Вторая цифра заданного числа равна: {result}");