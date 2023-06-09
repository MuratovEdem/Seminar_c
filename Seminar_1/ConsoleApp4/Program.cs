/* Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8 */

Console.Write("Введи целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (99 < number && number < 1000)
{
    int number_1 = number % 10;
    Console.WriteLine($"Последняя цифра этого числа равна: {number_1}");
}
else 
{
    Console.WriteLine("Введенное число не входит в диапазон");
}
