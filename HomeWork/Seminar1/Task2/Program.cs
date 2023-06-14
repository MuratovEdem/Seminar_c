// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введи первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число больше второго");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}