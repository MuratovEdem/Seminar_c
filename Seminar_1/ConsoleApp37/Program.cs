// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

int[,] array = new int[4,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

if (array.GetLength(0) != array.GetLength(1)){
    Console.WriteLine("Действие невозможно");
    Environment.Exit(0);
}

int[,] arrayNew = new int[array.GetLength(0), array.GetLength(1)];

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrayNew[j,i] = array[i,j];
    }
}

for (int i = 0; i < arrayNew.GetLength(0); i++)
{
    for (int j = 0; j < arrayNew.GetLength(1); j++)
    {
        Console.Write(arrayNew[i,j] + " ");
    }
    Console.WriteLine();
}