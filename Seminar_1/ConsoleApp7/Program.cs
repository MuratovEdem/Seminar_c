﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

Console.Write("Введи первое число: ");
int a = int.Parse(Console.ReadLine());


Console.Write("Введи второе число: ");
int b = int.Parse(Console.ReadLine());

int c = b % a;

if (c > 0)
{
    Console.WriteLine($"Второе число не кратно первому, остаток от деления равен {c}");
}
else
{
    Console.WriteLine($"Второе число кратно первому");
}