// Заполнить массив спирально 4 на 4 (первая версия)

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

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colmns];

Console.WriteLine();

Print(matrix);

Console.WriteLine();

int countRow = 0;
int countCol = 0;

if (rows % 2 == 0)
{
    countRow = rows / 2;
    countCol = colmns / 2 - 1;
}
else
{
    countRow = rows / 2;
    countCol = colmns / 2;
}

int row = 0;
int col = 0;
int right = matrix.GetLength(1) - 1;
int down = matrix.GetLength(0) - 1;
int left = 0;
int up = 0;

while (matrix[countRow, countCol] == 0)
{
    while (col < right)
    {
        if (matrix[row, col] == 0)
        {
            RandomNumberMatrix(row, col);
            col++;
        }
        else
        {
            col--;
            break;
        }
    }
    while (row < down)
    {
        if (matrix[row, col] == 0)
        {
            RandomNumberMatrix(row,col);
            row++;
        }
        else
        {
        row--;
            break;
        }
    }
    while (col > left)
    {
        if (matrix[row, col] == 0)
        {   
            RandomNumberMatrix(row,col);
            col--;
        }
        else
        {
            col++;
            break;
        }
    }
    while (row >= up)
    {
        if (matrix[row, col] == 0)
        {
            RandomNumberMatrix(row,col);
            row--;
        }
        else
        {
            row++;
            col++;
            break;
        }
    }
    right--;
    down--;
    left++;
    up++;
}

void RandomNumberMatrix(int row, int col)
{
    matrix[row, col] = new Random().Next(1,10);
    Print(matrix);
    Console.WriteLine();
}

// Вторая версия (с помощью интернета)

// Console.Write("Введи количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введи количество столбцов: ");
// int comns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, comns];

// int row = 0; 
// int col = 0; 
// int index = 1;
// int count = 0; 
// int dirChanges = 0;
// int gran = comns;

// for (int i = 0; i < matrix.Length; i++)
// {
//     matrix[col, row] = i + 1;
//     if (--gran == 0)
//     {
//         gran = comns * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//         int temp = index;
//         index = -count;
//         count = temp;
//         dirChanges++;
//     }
//     col += count;
//     row += index;
// }

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < comns; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
