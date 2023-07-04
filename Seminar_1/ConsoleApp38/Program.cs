// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int indexStr = 0;
int indexRow = 0;
int min = array[0,0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < min)
        {
            min = array[i,j];
            indexStr = i;
            indexRow = j;
        }
    }
}

for (int i = 0; i < array.GetLength(1); i++)
{
    int temp = 0;
    array[indexStr, i] = temp;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = 0;
    array[i, indexRow] = temp;
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

