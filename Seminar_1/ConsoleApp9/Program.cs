// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого

Console.Write("Введи первое число: ");
int a = int.Parse(Console.ReadLine());


Console.Write("Введи второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else if (b * b == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
