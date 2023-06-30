// Заполнить массив спирально 4 на 4

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[4,4];

void RandomNumber(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
            {
                arr[i,j] = random.Next(1, 10);
            }
        }
    }
}

void RunMatrix(int row, int col)
{
    if (matrix[row, col] == 0 || matrix[row, col] == matrix.GetLength(1) || matrix[row, col] == matrix.GetLength(0))
    {
        matrix[row, col] = 1;
        RunMatrix(row - 1, col);
        RunMatrix(row, col - 1);
        RunMatrix(row + 1, col);
        RunMatrix(row, col + 1);
    }
}

RandomNumber(matrix);
RunMatrix(0,0);
RandomNumber(matrix);



