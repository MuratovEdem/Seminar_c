// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);  // Случайное число от 10 до 99
Console.WriteLine($"Рандомное число: {number}");

int FirstDigit = number / 10;
int SecondDigit = number % 10;

if ( FirstDigit > SecondDigit)
{
    Console.WriteLine($"Наибольшая цифра в числе: {FirstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра в числе: {SecondDigit}");
}


