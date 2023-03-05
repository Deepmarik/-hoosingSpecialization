/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/
string[] word1 = { "hello", "2", "world", ":-)" };
string[] word2 = { "1234", "1567", "-2", "computer science" };
string[] word3 = { "Russia", "Denmark", "Kazan", "abc" };
void NewArray(string[] array)
{
    var resultArray = new string[array.Length];
    var count = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[count] = item;
            count++;
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, resultArray, 0, count));

}
NewArray(word2);
