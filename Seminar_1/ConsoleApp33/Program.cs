// Заполнить массив спирально 4 на 4

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



// Console.WriteLine();

// // RigtRun(0,0);

// DownRun(1,3);

// LeftRun(3,2);

// UpRun(2,0);

// RigtRun(1,1);

// DownRun(2,2);

// LeftRun(2,1);


// void DownRun(int row, int col)
// {
//     while (row < matrix.GetLength(0))
//     {
//         if (matrix[row, col] == 0)
//         {
//             matrix[row, col] = new Random().Next(1,10);
//             Print(matrix);
//             Console.WriteLine();
//             row++;
//         }
//         else
//         {
//             row--;
//             break;
//         }
//     }
// }

// void LeftRun(int row, int col)
// {
//     while (col >= 0)
//     {
//         if (matrix[row, col] == 0)
//         {
//             matrix[row, col] = new Random().Next(1,10);
//             Print(matrix);
//             Console.WriteLine();
//             col--;
//         }
//         else
//         {
//             col++;
//             break;
//         }
//     }
// }

// void UpRun(int row, int col)
// {
//     while (row >= 0)
//     {
//         if (matrix[row, col] == 0)
//         {
//             matrix[row, col] = new Random().Next(1,10);
//             Print(matrix);
//             Console.WriteLine();
//             row--;
//         }
//         else
//         {
//             row++;
//             break;
//         }
//     }
// }






// RunMatrix(0,0);

// void RunMatrix(int row, int col)
// {
//     if (matrix[row, col] == 0 && row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1)
//     {
//         matrix[row, col] = new Random().Next(1, 10);
//         Print(matrix);
//         Console.WriteLine();
//         RunMatrix(rows, col + 1);
//         RunMatrix(rows + 1, col);
//         RunMatrix(rows, col - 1);
//         RunMatrix(rows - 1, col);
//     }
// }



// RunMatrix(1, 1);

// int[,] InitMatrix(int rows, int colmns)
// {
//     int[,] tmp = new int[rows, colmns];
//     Random random = new Random();
//     tmp[0,0] = random.Next(1,2);
//     tmp[0,1] = random.Next(1,2);
//     tmp[0,2] = random.Next(1,2);
//     tmp[0,3] = random.Next(1,2);
//     tmp[0,4] = random.Next(1,2);
//     tmp[0,5] = random.Next(1,2);
//     tmp[1,5] = random.Next(1,2);
//     tmp[2,5] = random.Next(1,2);
//     tmp[3,5] = random.Next(1,2);
//     tmp[4,5] = random.Next(1,2);
//     tmp[5,5] = random.Next(1,2);
//     tmp[5,4] = random.Next(1,2);
//     tmp[5,3] = random.Next(1,2);
//     tmp[5,2] = random.Next(1,2);
//     tmp[5,1] = random.Next(1,2);
//     tmp[5,0] = random.Next(1,2);
//     tmp[4,0] = random.Next(1,2);
//     tmp[3,0] = random.Next(1,2);
//     tmp[2,0] = random.Next(1,2);
//     tmp[1,0] = random.Next(1,2);
//     return tmp;
// }


// void RunMatrix(int rows, int col)
// {
//     if (matrix[rows, col] == 0)
//     {
//         matrix[rows, col] = new Random().Next(1, 10);
//         Print(matrix);
//         Console.WriteLine();
//         RunMatrix(rows, col + 1);
//         RunMatrix(rows + 1, col);
//         RunMatrix(rows, col - 1);
//         RunMatrix(rows - 1, col);
//     }
// }



// void RandomNumber(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] == 0)
//             {
//                 arr[i,j] = random.Next(1, 10);
//             }
//         }
//     }
// }





// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FiilImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FiilImage(row - 1, col);
//         FiilImage(row, col - 1);
//         FiilImage(row + 1, col);
//         FiilImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FiilImage(13, 13);
// PrintImage(pic);
