// . Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = new double[4,6];

int[] arrayZero = new int [3] {10, 100, 1000};

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round(new Random().NextDouble() * arrayZero[new Random().Next(0, arrayZero.Length)], 2);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}



