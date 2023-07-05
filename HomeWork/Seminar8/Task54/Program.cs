// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InitArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[10,10];

InitArray(array);
PrintArray(array);

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    BubbleMenhod(array, i);
}

PrintArray(array);

void BubbleMenhod(int[,] arr, int i)
{
    int rigtGran = arr.GetLength(1);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int indexCol = 0;
        for (int k = 1; k < rigtGran; k++)
        {
            if (arr[i,indexCol] < arr[i,k])
            {
                int temp = arr[i,k];
                arr[i,k] = arr[i,indexCol];
                arr[i,indexCol] = temp;
            }
            indexCol++;
        }
        rigtGran--;
    }
}