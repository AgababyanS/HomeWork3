Console.Clear();
Console.WriteLine("Введите число от 100 до 999");
int num = int.Parse(Console.ReadLine ()!);
int result = num/10%10;
Console.WriteLine(num);
Console.WriteLine(result);