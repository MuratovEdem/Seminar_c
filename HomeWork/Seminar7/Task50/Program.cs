// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введи индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи индекс столбца: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4,4];

PrintArray(array);

Console.WriteLine();

CheckCondition(array, rows, colmns);

Console.WriteLine($"Значение элемента равно {ElementValue(array, rows, colmns)}");


int ElementValue(int[,] arr, int row, int col)
{
    int temp = arr[row, col];
    return temp;
}

void PrintArray (int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void CheckCondition(int[,] arr, int row, int col)
{
    if (row > arr.GetLength(0) - 1 || col > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемента с таким индексом нет");
        Environment.Exit(0);
    }
}