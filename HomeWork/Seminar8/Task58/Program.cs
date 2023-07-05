// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] array = new int[3,3];

int[,] array1 = new int[array.GetLength(0), array.GetLength(1)];

int[,] arrayResult = new int[array.GetLength(0), array.GetLength(1)];

InitArray(array);

PrintArray(array);

Console.WriteLine();

InitArray(array1);

PrintArray(array1);

Console.WriteLine();

for (int i = 0; i < arrayResult.GetLength(0); i++)
{
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
        arrayResult[i,j] = MultiplicationMatrix(array, array1, i, j);
    }
}

PrintArray(arrayResult);

int MultiplicationMatrix(int[,] arr, int[,] arr1, int i, int j)
{
    int number = 0;
    int result = 0;
    for (int k = 0; k < 3; k++)
    {
        number = arr[i,k] * arr1[k,j];
        result = result + number;
    }
    return result;
}


