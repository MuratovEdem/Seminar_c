// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}