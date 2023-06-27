// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = new int[10] { 1, 4, 7, 94, 54, -2, 45, 43, -1, 7 };

int[] arrayNew = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    arrayNew[i] = array[i];
    Console.Write(arrayNew[i] + " ");
}
