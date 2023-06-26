// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Ведите степень числа: ");
int degree = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 0; i < degree; i++)
{
    result = result * number;
}
Console.WriteLine(result);
