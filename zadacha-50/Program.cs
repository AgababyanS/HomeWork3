//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine()!);

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(0, 21);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Write($"{array[i, j]}\t");
    WriteLine();
}

WriteLine("Введите искомую координату a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите искомую координату b: ");
int b = int.Parse(ReadLine()!);

if ((a >= 0 && a < m) && (b >= 0 && b < n))
{
    int c = array[a, b];
    WriteLine($"[{a},{b}]={c}");
}
else
{
    WriteLine("такого числа нет");
}