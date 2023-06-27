

// int[] array = new int[10] {1, 4, 7, 94, 54, -2, 45, 43, -1, 7};

// int[] reverseArray = new int[array.Length];

// for (int i = 0; i < reverseArray.Length; i++)
// {
//     reverseArray[i] = array[(array.Length -1) - i];
// }
// for (int i = 0; i < reverseArray.Length; i++)
// {
//     Console.Write(reverseArray[i] + " ");
// }

int[] array = new int[10] {1, 4, 7, 94, 54, -2, 45, 43, -1, 7};

for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}