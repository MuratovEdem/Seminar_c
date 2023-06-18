// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Write("Ведите любое число: ");
int number = int.Parse(Console.ReadLine());

int count = 1;
int result = 1;

if (number > 99)
{
    while (count > 0)
    {
        result = (result * 10) + (number % 10);
        count = number / 10;
    }
}
else
{
    Console.WriteLine("число вне диапазона");
}
Console.WriteLine(result);