// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1 Если N = 7 -> 0 1 1 2 3 5 8


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;

Console.Write("0 1 ");

for (int i = 2; i < number; i++)
{
    int result = a + b;
    Console.Write(result + " ");
    a = b;
    b = result;
}

