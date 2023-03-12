//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());

void NumberCounter (int N)
{
    if (N < 0) Write($"{N} не натуральное число");
    if (N == 0) return;
    Write("{0,4}", N);
    NumberCounter (N - 1);
}

NumberCounter(N);