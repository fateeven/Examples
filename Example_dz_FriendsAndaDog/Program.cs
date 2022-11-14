
using System;
Console.Clear();
int count = 0;
int distance = 10000;
int firstFrendSpeed = 1;
int secondFreindSpeed = 2;
int dogSpeed = 5;
int freind = 2;
int T = 0;
while (distance < 10)
{
    if (freind == 1)
    {
        T = distance / (firstFrendSpeed + dogSpeed);
        freind = 2;
    }
    if (freind == 2)
    {
        T = distance / (secondFreindSpeed + dogSpeed);
        freind = 1;
    }

    distance = distance - (firstFrendSpeed + secondFreindSpeed) * T;
    count = count + 1;
       
    Console.Write("Кол-во раз пробежала собака:  ");
    Console.WriteLine(count);
}
