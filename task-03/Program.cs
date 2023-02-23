int counter = 2;
Console.Write("Введите число N>0:");
int N = int.Parse(Console.ReadLine()??"0");
    while (counter <= N)
    {
    Console.Write(counter);
        if (counter < N-1)
        {
        Console.Write(",");
        }   
    counter+=2;
    }
    Console.WriteLine("");
    
