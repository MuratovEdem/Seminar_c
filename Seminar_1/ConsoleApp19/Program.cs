// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

int sum_positive = 0;
int sum_negative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum_positive = sum_positive + array[i];
    }
    if (array[i] < 0)
    {
        sum_negative = sum_negative + array[i];
    }
}

Console.WriteLine($"Сумма положительных чисел {sum_positive}");
Console.WriteLine($"Сумма отрицательных чисел {sum_negative}");