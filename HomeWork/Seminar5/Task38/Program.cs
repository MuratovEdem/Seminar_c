// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];

int[] arrayZero = new int [3] {10, 100, 1000}; // Массив для изменения разрядности числа в основном массиве

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * arrayZero[new Random().Next(0, arrayZero.Length)], 2); 
    Console.Write(array[i] + " "); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
}

Console.WriteLine();

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
}

double result = Math.Round(max - min, 2);

Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {result}");
