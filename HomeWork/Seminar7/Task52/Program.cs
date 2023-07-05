// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[4,4];

PrintArray(array);

Console.WriteLine();

GetArithmeticMean(array);


void GetArithmeticMean (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j,i];
        }
        double result = Math.Round(sum / 4, 2);
        Console.WriteLine($"Среднее арифметическое в {i + 1} столбце равна {result}");
    }
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


