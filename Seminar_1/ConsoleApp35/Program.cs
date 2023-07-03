// кто хочет стать миллионером

string question1 = "Вопрос 1: Что народная мудрость советует отдать врагу?";
string question1AnswerOption = "a) завтрак     b) обед     c) полдник     d) ужин"; // 

string question2 = "Вопрос 2: Чему в Туле установлен памятник?";
string question2AnswerOption = "a) хлебу     b) кексу     c) бублику     d) прянику"; // d

string question3 = "Вопрос 3: Чего не ела героиня сказки «Гуси-лебеди», когда спасалась с братцем от погони?";
string question3AnswerOption = "a) пирожок     b) фуа-гра     c) кисель     d) яблоко"; // b

string question4 = "Вопрос 4: Что обычно едят горячим?";
string question4AnswerOption = "a) окрошку     b) гаспачо     c) рассольник     d) свекольник"; // c

string question5 = "Вопрос 5: Что Китай недавно объявил своим национальным достоянием, вызвав возмущение граждан Южной Кореи?";
string question5AnswerOption = "a) онигири     b) кимчи     c) ушу     d) группу 'BTS'"; // b

string question6 = "Вопрос 6: Какой ингредиент знаменитой пиццы «Маргарита» не символизирует ни один из цветов флага Италии?";
string question6AnswerOption = "a) оливковое масло     b) томаты     c) моцарелла     d) базилик"; // a

string question7 = "Вопрос 7: В блюде немецкой кухни «Небо и земля» картофель — это земля. А что символизирует небеса?";
string question7AnswerOption = "a) грибы     b) петрушка     c) яблоки     d) клубника"; // c

string question8 = "Вопрос 8: Какое блюдо создал французский повар Андре Дюпон, состоявший на службе у русского графа?";
string question8AnswerOption = "a) бефстроганов     b) цыпленок табака     c) шницель по-венски     d) ростбиф"; // a

string question9 = "Вопрос 9: Неправильное написание какого слова объясняется тем, что мода на блюдо пришла не из Японии, а из Европы?";
string question9AnswerOption = "a) темпура     b) рамэн     c) суши     d) гедза"; // c

string question10 = "Вопрос 10: Что стало популярным благодаря «Ресторану трех корон», обслуживавшему посетителей Всемирной выставки 1939 года?";
string question10AnswerOption = "a) коктейли     b) фастфуд     c) шведский стол     d) еда на вынос"; // c

int lose = 0;
int win = 0;
string answer = String.Empty;

while (lose < 2 && win < 10)
{
    Console.WriteLine(question1);
    Console.WriteLine(question1AnswerOption);
    answer = Console.ReadLine();
    

}



