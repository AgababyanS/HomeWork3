// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
Console.WriteLine($"всего {numbers.Length} чисел, {GetCountOfEven(numbers)} из них чётные");


int GetCountOfEven(int[] array) 
{
    int count = 0;
    // int item = 0;
    // for (int i=0; i<array.Length;i++)
    // {
    //     item = array[i]
    //     if (item %2 == 0) count++;
    // }
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}