// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");

int a = number / 100; 
int b = number % 10;

int result = (a * 10) + b;
Console.Write(result);