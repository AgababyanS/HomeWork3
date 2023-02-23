int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; 1<=n; i++)
        sum += i;
    return sum;
}


Console.Clear();
Console.Write("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");