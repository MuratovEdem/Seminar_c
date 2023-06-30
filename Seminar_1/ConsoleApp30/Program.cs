// Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, colmns);

Print(matrix);

int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            tmp[i,j] = i + j;
        }
    }
    return tmp;
}

void Print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{ arr[i,j] }  ");
        }
        Console.WriteLine();
    }
}