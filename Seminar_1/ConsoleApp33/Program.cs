// Заполнить массив спирально 4 на 4

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, colmns);

Random random = new Random();


int[,] RightRun(int rows, int colmns)
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








for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colms; j++)
    {
        if (j < colms || j + 1 > 0)
        {
            matrix[i,j] = random.Next(1, 10);
            break;
        }
        if (i < rows || i + 1 > 0)
        {
            matrix[i,j] = random.Next(1, 10);
            break;
        }
        if (j < colms || j + 1 > 0)
        {
            matrix[i,j] = random.Next(1, 10);
            break;
        }
        if (i < rows || i + 1 > 0)
        {
            matrix[i,j] = random.Next(1, 10);
            break;
        }
    }
}








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






