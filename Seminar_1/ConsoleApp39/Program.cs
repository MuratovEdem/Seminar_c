// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

int[,] array = new int[4,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,5);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Dictionary<int, string> slovar = new Dictionary<int, string>();


for (int i = 0; i < length; i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (run == array[j,k]){

            }
        }
    }



}
