// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;
if (number == 0)
{
    Console.WriteLine($"Количество цифр в числе 1");
}
else
{
    while (number != 0)
    {
        count++;
        number /= 10;
    }
    Console.WriteLine($"Количество цифр в числе {count}");
}
