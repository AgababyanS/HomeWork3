 Console.WriteLine("Введите число a");
 int a = int.Parse(Console.ReadLine ()!);
 Console.WriteLine("Введите число b");
 int b = int.Parse(Console.ReadLine ()!);
 Console.WriteLine("Введите число c");
 int c = int.Parse(Console.ReadLine ()!);
 int Max = a;
 if (a>b)
    {
        if (a>c)
            Max = a;
        else
            Max = c; 
    }
 if (a<b)    
    {
        if (b>c)
            Max = b;
        else     
            Max = c;
}        

Console.Write(Max);