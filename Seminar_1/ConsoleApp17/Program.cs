// Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

int number_1 = 1;
for (int i = 1; i <= number; i++)
{
    number_1 = number_1 * i;
}
Console.WriteLine($"Произведение чисел равно {number_1}");
