void Print2DArray(int[,] int2DArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            //Console.Write($"{i},{j} {int2DArray[i, j]}\t");
            Console.Write($"{int2DArray[i, j]}\t");

        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] Create2DimArray(int hight, int length, int min, int max)
{
    int[,] int2DArray = new int[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int2DArray[i, j] = new Random().Next(min, max);
        }
    }

    return int2DArray;
}

// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.


bool isInArray(int value, int[,] int2DArray)
{
    foreach (int item in int2DArray)
    {
        if (item == value) return true;
    }
    return false;
}

// вспомогательный метод, считаем сколько элементов в массиве
int countArrayElement(int value, int[,]int2DArray)
{
    int counter = 0;
    foreach (int item in int2DArray)
    {
        if (value == item) counter++;
    }
    return counter;
}

int[,] GetFrequencyArray(int[,] int2DArray)
{
    int[,] frequencyArray = new int[int2DArray.Length, 2];
    int element = 0;

    // для проверки, если в исходном массиве появится "0"
    int zeroElement = 0;

    foreach (int item in int2DArray)
    {
        // изначально frequencyArray состоит из 0, поэтому исключаем еще и "item = 0"
        // обработаем их дальше в else if
        if (!isInArray(item, frequencyArray) && item != 0)
        {
            frequencyArray[element, 0] = item;
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
        }
        else if(item == 0 && zeroElement == 0)
        {
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
            zeroElement++;
        }
        element++;
    }

    return frequencyArray;
}

// вывод частотного массива на консоль
void PrintFrequencyArray(int[,] frequencyArray)
{
    for (int i = 0; i < frequencyArray.GetLength(0); i++)
    {
        if(frequencyArray[i,1] != 0)
            Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
    }
}

int[,] myArray = Create2DimArray(3, 5, 1, 10);
Print2DArray(myArray);
int[,] myFrArray = GetFrequencyArray(myArray);
PrintFrequencyArray(myFrArray);


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.WriteLine("Key = {0}");
//     }
// }

// var counts = new Dictionary<int, string>();
// Console.Write("Input your text: ");
// int[,] array = new int[4,4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,5);
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// // Пробегаемся по полученную после разделения текста массиву слов и складываем в словарь
// foreach(var word in words) {
// if (!counts.ContainsKey(word.ToLower())) counts.Add(word.ToLower(), 1);
// else counts[word] += 1;
// }
        
// // Пробегаемся по словарю и выводим все элементы
// foreach(var pair in counts) {
// Console.WriteLine(pair.Key + ": " + pair.Value);
// }
        
