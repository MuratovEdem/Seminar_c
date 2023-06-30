// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, colmns);

Print(matrix);

Console.WriteLine();

int sum = DiagonalMatrix(matrix);

Console.WriteLine(sum);

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

int DiagonalMatrix(int[,] arr){
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            if (i == j)
            {
                sum = sum + arr[i, j];
            }
        }
    }
    return sum;
}

