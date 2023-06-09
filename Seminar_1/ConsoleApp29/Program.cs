﻿// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

Console.Write("Введи первое число: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи первое число: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, colmns);

Print(matrix);

GetMatrix(matrix);

Console.WriteLine();

Print(matrix);


int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            tmp[i,j] = random.Next(1, 101);
        }
    }
    return tmp;
}

void GetMatrix(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(1, 101);
        }
    }
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