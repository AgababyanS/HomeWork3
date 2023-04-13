Console.Clear();
Console.Write("Введите число:");
double number = double.Parse(Console.ReadLine());

for (double i = 1; i <= number; i++)
{
double result = Math.Pow(i,2);
Console.WriteLine($"{number}->{result}");
}