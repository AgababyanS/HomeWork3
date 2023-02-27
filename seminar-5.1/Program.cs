//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
 GetArray(12,-9,9);


 int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size];

     for (int i = 0; i < size; i++)
     {
         res[i] = new Random().Next(minValue, maxValue + 1);
     }
     return res;
}