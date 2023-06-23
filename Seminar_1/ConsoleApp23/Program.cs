// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int[] array_new = null;
if (array.Length % 2 == 0)
{
    array_new = new int[array.Length / 2];
}
else
{
    array_new = new int[array.Length / 2 + 1];
}
int index = 0;
int count = 0;
int size = array.Length - 1;
int sum = 0;
while (count <= size)
{
    if (count == size)
    {
        array_new[index] = array[count];
        Console.Write(array_new[index] + " ");
    }
    else
    {
        sum = array[count] * array[size];
        array_new[index] = sum;
        Console.Write(array_new[index] + " ");
    }
    index++;
    count++;
    size--;
}

