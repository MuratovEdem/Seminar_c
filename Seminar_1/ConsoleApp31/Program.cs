// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, colmns);

Print(matrix);

Console.WriteLine();

CheckMatrix(matrix);

Print(matrix);

int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            tmp[i,j] = random.Next(1, 11);;
        }
    }
    return tmp;
}

int[,] CheckMatrix(int[,] arr){
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
    return arr;
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