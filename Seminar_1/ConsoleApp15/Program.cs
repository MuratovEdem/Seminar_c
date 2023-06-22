// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

Console.Write("Ведите число: ");
int n = int.Parse(Console.ReadLine());
int sum_n = 0;

for (int i = 1; i <= n; i++)
{
    sum_n = sum_n + i;
}
Console.WriteLine($"Сумма числе равна {sum_n}");
