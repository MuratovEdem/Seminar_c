// Заполнить массив спирально 4 на 4

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int comns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, comns];

int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = comns;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[col, row] = i + 1;
    if (--gran == 0)
    {
        gran = comns * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dy;
    row += dx;
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < comns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
