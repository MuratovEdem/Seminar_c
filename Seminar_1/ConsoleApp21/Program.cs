// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] array = new int[6] {2, 45, -23, 43, -12, -4};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

bool isFound = false;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        isFound = true;
        break;
    }
}
Console.WriteLine((isFound ? "Да" : "Нет"));

