// Программа на вход принимает число (может быть любой размерности). 
// Необходимо вывести количество цифр в этом числе.
// Не используя работу со строками. Использовать цикл while

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

while (a != 0)
{
    b = a % 10;
    a = a / 10;
    Console.Write(b);
}

/* int count = 0;
while (a != 0)
{
    a = a / 10;
    count++;
}
Console.Write(count);*/