// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

double cubing(int number)
{
    double result = Math.Pow(number, 3);
    return result;
}

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

int count = 1;

while (count <= number)
{
    double result = cubing(count);
    Console.Write($"{result} ");
    count++;
}



