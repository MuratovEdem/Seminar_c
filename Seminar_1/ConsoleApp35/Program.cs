// кто хочет стать миллионером

string question1 = @"Вопрос 1: Что народная мудрость советует отдать врагу?
a) завтрак     b) обед     c) полдник     d) ужин"; // d

string question2 = @"Вопрос 2: Чему в Туле установлен памятник?
a) хлебу     b) кексу     c) бублику     d) прянику"; // d

string question3 = @"Вопрос 3: Чего не ела героиня сказки «Гуси-лебеди», когда спасалась с братцем от погони?
a) пирожок     b) фуа-гра     c) кисель     d) яблоко"; // b

string question4 = @"Вопрос 4: Что обычно едят горячим?
a) окрошку     b) гаспачо     c) рассольник     d) свекольник"; // c

string question5 = @"Вопрос 5: Что Китай недавно объявил своим национальным достоянием, вызвав возмущение граждан Южной Кореи?
a) онигири     b) кимчи     c) ушу     d) группу 'BTS'"; // b

string question6 = @"Вопрос 6: Какой ингредиент знаменитой пиццы «Маргарита» не символизирует ни один из цветов флага Италии?
a) оливковое масло     b) томаты     c) моцарелла     d) базилик"; // a

string question7 = @"Вопрос 7: В блюде немецкой кухни «Небо и земля» картофель — это земля. А что символизирует небеса?
a) грибы     b) петрушка     c) яблоки     d) клубника"; // c

string question8 = @"Вопрос 8: Какое блюдо создал французский повар Андре Дюпон, состоявший на службе у русского графа?
a) бефстроганов     b) цыпленок табака     c) шницель по-венски     d) ростбиф"; // a

string question9 = @"Вопрос 9: Неправильное написание какого слова объясняется тем, что мода на блюдо пришла не из Японии, а из Европы?
a) темпура     b) рамэн     c) суши     d) гедза"; // c

string question10 = @"Вопрос 10: Что стало популярным благодаря «Ресторану трех корон», обслуживавшему посетителей Всемирной выставки 1939 года?
a) коктейли     b) фастфуд     c) шведский стол     d) еда на вынос"; // c


string[,] answerOptions = new string[10, 4] {{"a) завтрак", "b) обед", "c) полдник", "d) ужин"},
                                             {"a) хлебу", "b) кексу", "c) бублику", "d) прянику"},
                                             {"a) пирожок", "b) фуа-гра", "c) кисель", "d) яблоко"},
                                             {"a) окрошку", "b) гаспачо", "c) рассольник", "d) свекольник"},
                                             {"a) онигири", "b) кимчи", "c) ушу", "d) группу 'BTS'"},
                                             {"a) оливковое масло", "b) томаты", "c) моцарелла", "d) базилик"},
                                             {"a) грибы", "b) петрушка", "c) яблоки", "d) клубника"},
                                             {"a) бефстроганов", "b) цыпленок табака", "c) шницель по-венски","d) ростбиф"},
                                             {"a) темпура", "b) рамэн", "c) суши", "d) гедза"},
                                             {"a) коктейли", "b) фастфуд", "c) шведский стол", "d) еда на вынос"}};

string[,] questionsArray = new string[2, 10] { {question1, question2, question3, question4, question5, question6, question7, question8, question9, question10},
                                               {"d", "d", "b", "c", "b", "a", "c", "a", "c", "c"} };

Console.WriteLine(@"Правила игры: пиши варианты ответов английскими строчными буквами. У вас есть запасная жизнь.
Также у вас есть подсказки, для их вызова напишите цифру '1' выдаст подсказку 50 на 50; цифра '2' выдаст подсказку Звонок другу; 
и при вводе цифры '3' вы воспользуетесь помощью зала. Надеюсь правила понятны, приятной игры. Для повторного вызова правил игры нажмите '4'");

Console.WriteLine();

int countLife = 0;
int count50on50 = 0;
int countPhone = 0;
int countHall = 0;

for (int i = 0; i < questionsArray.GetLength(1); i++)
{
    Console.WriteLine(questionsArray[0, i]);
    string answerquestion = CorrectValue();
    if (answerquestion == "1") // подсказка 50 на 50
    {
        if (count50on50 == 0)
        {
            count50on50++;
            Get50on50(answerOptions, questionsArray, i);
            answerquestion = CorrectValue();
        }
        else
        {
            Console.WriteLine("К сожалению вы уже использовали подсказку '50 на 50'");
            Console.WriteLine();
            Console.WriteLine(questionsArray[0, i]);
            answerquestion = CorrectValue();
        }
    }
    if (answerquestion == "2") // подсказка звонок другу
    {
        if (countPhone == 0)
        {
            countPhone++;
            GetCallFriend(questionsArray, i);
            Console.WriteLine("Каков будет ваш ответ на вопрос");
            Console.WriteLine();
            Console.WriteLine(questionsArray[0, i]);
            answerquestion = CorrectValue();
        }
        else
        {
            Console.WriteLine("К сожалению вы уже использовали подсказку 'Звонок другу'");
            Console.WriteLine();
            Console.WriteLine(questionsArray[0, i]);
            answerquestion = CorrectValue();
        }
    }
    if (answerquestion == "3") // подсказка помощь зала
    {
        if (countHall == 0)
        {
            countHall++;
            GetHallHelp(questionsArray, i);
            Console.WriteLine("Что вы ответите на вопрос?");
            Console.WriteLine();
            Console.WriteLine(questionsArray[0, i]);
            answerquestion = CorrectValue();  
        }
        else
        {
            Console.WriteLine("К сожалению вы уже использовали подсказку 'Помощь зала'");
            Console.WriteLine();
            Console.WriteLine(questionsArray[0, i]);
            answerquestion = CorrectValue();
        }
    }
    if (questionsArray[1, i] == answerquestion)
    {
        Console.WriteLine();
        Console.WriteLine("Совершенно верно! Это правильный ответ");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("К сожалению ответ неверный");
        countLife++;
        if (countLife == 1)
        {
            Console.WriteLine("Но не огорчайтесь, ведь у вас есть еще 1 попытка");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("У вас закончились попытки. Вы проиграли");
            Environment.Exit(0);
        }
    }
}
Console.WriteLine("Поздравляем вы победили в игре 'Кто хочет стать миллионером'");


void Get50on50(string[,] Options, string[,] Questions, int i)
{
    Console.WriteLine("Вы воспользовались подсказкой '50 на 50'");
    if (Questions[1,i] == "a" || Questions[1,i] == "b"){
        string temp = Options[i, 0] + " " + Options[i, 1];
        Console.WriteLine("Оставшиеся варианты ответов: ");
        Console.WriteLine(temp);
    }
    if (Questions[1,i] == "c" || Questions[1,i] == "d"){
        string temp = Options[i, 2] + " " + Options[i, 3];
        Console.WriteLine("Оставшиеся варианты ответов: ");
        Console.WriteLine(temp);
    }
}

void GetCallFriend(string[,] Questions, int i)
{
    Console.WriteLine(@"Вы решили воспользоваться звонком другу. Выберите одного друга из списка (напишите цирфу рядом с именем)
1) Андрей    2) Тимур     3) Настя");
    string answer = Console.ReadLine();
    if (answer == "1"){
        Console.WriteLine("Андрей не знает правильного ответа и наугад отвечает: " + Questions[1,i]);
    }
    if (answer == "2"){
        Console.WriteLine("Тимур уверенно заявляет, что правильный ответ: " + Questions[1,i]);
    }
    if (answer == "3"){
        Console.WriteLine("В ходе недолгих раздумий Настя дает ответ: " + Questions[1,i]);
    }
}

void GetHallHelp(string[,] Questions, int i)
{
    Console.WriteLine("Вы воспользовались подсказкой 'Помощь зала'. И вот что отвечают зрители");
    if (Questions[1,i] == "a"){
        Console.WriteLine(@"86% зрителей выбрали вариант ответа 'a'; 4% зрителей выбрали вариант 'b'; 
7% зрителей выбрали вариант 'c'; 3% зрителей выбрали вариант 'd'");
    }
    if (Questions[1,i] == "b"){
        Console.WriteLine(@"5% зрителей выбрали вариант ответа 'a'; 82% зрителей выбрали вариант 'b'; 
6% зрителей выбрали вариант 'c'; 7% зрителей выбрали вариант 'd'");
    }
    if (Questions[1,i] == "c"){
        Console.WriteLine(@"10% зрителей выбрали вариант ответа 'a'; 1% зрителей выбрали вариант 'b'; 
88% зрителей выбрали вариант 'c'; 1% зрителей выбрали вариант 'd'");
    }
    if (Questions[1,i] == "d"){
        Console.WriteLine(@"2% зрителей выбрали вариант ответа 'a'; 3% зрителей выбрали вариант 'b'; 
1% зрителей выбрали вариант 'c'; 94% зрителей выбрали вариант 'd'");
    }
}

string CorrectValue()
{
    string answer = Console.ReadLine();
    if (answer == "4")
    {
        Console.WriteLine(@"Правила игры: пиши варианты ответов английскими строчными буквами. У вас есть запасная жизнь.
Также у вас есть подсказки, для их вызова напишите цифру '1' выдаст подсказку 50 на 50; цифра '2' выдаст подсказку Звонок другу; 
и при вводе цифры '3' вы воспользуетесь помощью зала. Надеюсь правила понятны, приятной игры. Для повторного вызова правил игры нажмите '4'");
        answer = Console.ReadLine();
    }
    if (answer == "a" || answer == "b" || answer == "c" || answer == "d" || answer == "1" || answer == "2" || answer == "3")
    {
        return answer;
    }
    else
    {
        int count = 0;
        while (count < 1)
        {
            Console.WriteLine("Введено некорректное значение, пожалуйста, попробуйте снова");
            answer = Console.ReadLine();
            if (answer == "a" || answer == "b" || answer == "c" || answer == "d" || answer == "1" || answer == "2" || answer == "3")
            {
                count++;
            }
            
        }
        return answer;
    }
}
