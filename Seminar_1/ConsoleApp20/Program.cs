// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] array = new int[6] {2, 45, -23, 43, -12, -4};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
    Console.Write(array[i] + " ");
}
