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


// Цикл for Пример вывода таблицы умножения
for (int i=2; i <= 10; i++)
{
    for (int j=2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}   "); // - Интерполяция строк
    }
    Console.WriteLine();
}


//Задача.
// Дан текст.  В тесте  все пробелы заменить черточкми - ,
// Маленькие буквы "к" заменить большими "К",
// а большие "С"заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю? ССС";

// Пример работы:

//string s = "qwerty"
//            012345
//s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; 
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result; // не забывать возвращать результат в 4 Виде.
}
string newText = Replace(text, ' ', '|' );
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К' );  
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с' );
Console.WriteLine(newText);
Console.WriteLine();

// Задача сортировка одномерного массива, по возрастанию.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);