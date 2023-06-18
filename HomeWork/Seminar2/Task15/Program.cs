// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Ведите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case (1):
        Console.Write("Понедельник рабочий день");
        break;
    case (2):
        Console.Write("Вторник рабочий день");
        break;
    case (3):
        Console.Write("Среда рабочий день");
        break;
    case (4):
        Console.Write("Четверг рабочий день");
        break;
    case (5):
        Console.Write("Пятница рабочий день");
        break;
    case (6):
        Console.Write("Суббота ВЫХОДНОЙ!");
        break;
    case (7):
        Console.Write("Воскресенье ВЫХОДНОЙ!");
        break;
    default:
        Console.Write("Такого дня недели не существует");
        break;
}




