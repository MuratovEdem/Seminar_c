// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

Console.Write("Ведите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int result = 0;
int number_1 = number;

if (number > 9999 && number < 100000)
{
    while (number_1 != 0)
    {
        result = (result * 10) + (number_1 % 10);
        number_1 = number_1 / 10;
    }
    if (number == result)
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}
else
{
    Console.Write("Число не пятизначное");
}