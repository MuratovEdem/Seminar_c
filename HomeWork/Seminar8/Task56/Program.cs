// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[,] array = new int[5,4];

InitArray(array);
PrintArray(array);

int result = SumRow(array, 0);
int number = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = SumRow(array, i);
    if (sum < result)
    {
        result = sum;
        number = i + 1;
    }

}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {number}");

int SumRow(int[,] arr, int i)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i,j];
    }
    return sum;
}




