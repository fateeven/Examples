// Вид 1
void Method1()
{
    Console.WriteLine("Автор Фатеев Е.Н.");
}
// вызываються следующим образом:
Method1();



// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// вызываються следующим образом:
Method2(msg: "текст сообщения");
//2-ой пример
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; //increment - это увеличение счетчика на еденицу
             //decrement - это уменьшение счетчика на еденице    
    }
}
// вызываються следующим образом:
Method21("Текст сообщения 2", 4);
// можно вызвать метод через именнованные аргументы (сount: и msg:) вот так:
Method21(count: 4, msg: "Текст 4"); // необязательно аргументы писать по порядку
Method21(count: 2, msg: "Текст 2");
Method21(count: 1, msg: "Текст 1");


// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
// вызываються следующим образом:
int Year = Method3();
Console.WriteLine(Year);

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   // = String.Empty; - = пустая строка
    
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// вызываються следующим образом:
string res = Method4(6, "ве ");
string res0 = Method4(6, "ло ");
string res1 = Method4(6, "си ");
string res2 = Method4(6, "пе ");
string res3 = Method4(6, "ди ");
string res4 = Method4(6, "ст ");
Console.WriteLine(res);
Console.WriteLine(res0);
Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);
Console.WriteLine(res4);