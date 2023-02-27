//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = GetMin(numbers);  // double min=numbers[0];  // double min = GetMinMax(numbers)[0];
double max = GetMax(numbers);  // double max =numbers[0]; // double max = GetMinMax(numbers)[1];

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// double [] GetMinMax(double [] numbers)
// {   
//     double max = numbers[0];
//     double min = numbers[0];
//     double [] minmax = new double[2];
//     for (int z = 1; z < numbers.Length; z++)
//         {
//             if (numbers[z] > max)
//                 {
//                     max = numbers[z];
//                 }
//             if (numbers[z] < min)
//                 {
//                     min = numbers[z];
//                 }
//         }
//     minmax[0] = min;
//     minmax[1] = max;
//     return minmax;
// }

double GetMax(double[] numbers)
{ double max = numbers[0];
    for (int z = 1; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
            {
                max = numbers[z];
            } 
    }

// foreach (var item in numbers)
//     {  if (item > max)
//             {
//                 max = item;
//             }
//     }

return max;
}
double GetMin(double[] numbers)
{
double min = numbers[0];

for (int z = 1; z < numbers.Length; z++)
    {
        if (numbers[z] < min)
            {
                min = numbers[z];
            }
    }
// foreach (var item in numbers)
//     {  if (item < min)
//             {
//                 min = item;
//             }
//     }
return min;
}

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}