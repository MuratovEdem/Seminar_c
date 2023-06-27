// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины

Console.Write("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


if (a >= b + c || b >= a + c || c >= a + b)
{
    Console.WriteLine("Такого треугольника не существует");
    Environment.Exit(0);
}

Console.WriteLine("Такой треугольник может существовать");
