// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.

double pow_a(int count)
{
    double result = Math.Pow(count, 2);
    return result;
}

Console.Write("Ведите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    double result = pow_a(count);
    Console.WriteLine($"{result} ");
    count++;
}