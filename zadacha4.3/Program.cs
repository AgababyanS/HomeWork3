int GetX(int N)
{
    int X = 1;
    for (int i = 1; i <=N; i++ )
    X = X * i;           
    return X;
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение от 1 до {N} равна {GetX(N)}");

