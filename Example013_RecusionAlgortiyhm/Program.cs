﻿// string[,] table = new string[2, 5];
// // String.Empty            
// //table[0,0] table[0,1] table[0,2] table[0,3] table [0,4] 
// //table[1,0] table[1,1] table[1,2] table[1,3] table [1,4] 

// // table[1,2] = "слово"; //обращение к тексту

// // for (int rows = 0; rows < 2; rows++)
// // {
// //     for (int colums = 0; colums < 5; colums++)
// //     {
// //         Console.Write($"-{table[rows, colums]}-");
// //     }
// //     Console.WriteLine();
// // }

// // int[,] matrix = new int[3, 4]; //обращение к числам

// //метод печати таблицы по числам
// void PrintArrey(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// //метод заполнения матрицы случайными числами
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// int[,] matrix = new int[3, 4]; //обращение к числам

// PrintArrey(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArrey(matrix);

// //метод рисования по исходному коду
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0)
//             {
//                 Console.Write(" ");
//             }
//             else
//             {
//                 Console.Write("+");
//             }
//         }
//         Console.WriteLine();
//     }
// }


// //метод алгоритма закрашивания рисунка(рекурсия)
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }



// PrintImage(pic); //pic исходный код картинкиб на скрине выше
// FillImage(13, 13); // случайные точки
// PrintImage(pic);


// //метод котрый будет принмать число, факториал которого нужно будет вычислить(рекурсия)
// double Factorial(int n)
// {
//     if(n==1)
//     {   //0!=1; 1!=1;
//         return 1;
//     }   
//     else
//     {
//         return n*Factorial(n-1);
//     } 
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


//метод фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)
double Fibonacci(int n)
{
    if(n==1||n==2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}