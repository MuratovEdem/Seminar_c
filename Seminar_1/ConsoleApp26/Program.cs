//  Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

string word = "";

while (number > 0)
{
    if (number % 2 == 1)
    {
        word = 1 + word;
    }
    else
    {
        word = 0 + word;
    }
    number = number / 2;
}

Console.Write(word);


// for (int i = word.Length - 1; i >= 0; i--)
// {
//     Console.Write(word[i]);
// }