// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Write("Ведите любое число: ");
int number = int.Parse(Console.ReadLine());

int result = 0;
if ((-99 > number) || (number > 99))
{
    if (number > 99)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        result = number % 10;
        Console.WriteLine($"Третья цифра заданного числа равна {result}");
    }
    if (number < -99)
    {
        while (number < -1000)
        {
            number = number / 10;
        }
        result = number % 10;
        Console.WriteLine($"Третья цифра заданного числа равна {Math.Abs(result)}");
    }
    
}
else
{
    Console.WriteLine("Число вне диапазона");
}