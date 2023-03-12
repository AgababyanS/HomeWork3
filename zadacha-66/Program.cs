//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

Write("Введите начальное число M:");
int numberM = int.Parse(ReadLine());
Write("Введите начальное число M:");
int numberN = int.Parse(ReadLine());

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);