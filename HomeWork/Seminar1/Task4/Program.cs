// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введи первое число: ");
int FirstDigit = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int SecondDigit = int.Parse(Console.ReadLine());

Console.Write("Введи третье число: ");
int ThirdDigit = int.Parse(Console.ReadLine());

int max = FirstDigit;

if (SecondDigit > max)
{
    max = SecondDigit;
}
if (ThirdDigit > max)
{
    max = ThirdDigit;
}
Console.Write($"Наибольшее число равно {max}");