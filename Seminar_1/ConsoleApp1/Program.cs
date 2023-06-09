/* Напишите программу, которая на вход
принимает число и выдает его квадрат*/

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());

// Квадрат входного числа
int result = number * number;

// Вывод результата
Console.WriteLine($"Квадрат входного числа: {result}");