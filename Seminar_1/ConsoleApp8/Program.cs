// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.Write("Введи число: ");
int a = int.Parse(Console.ReadLine());

int b = a % 7;
int c = a % 23;

if (b == 0 && c == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}