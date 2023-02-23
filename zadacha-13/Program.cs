int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Clear();
Console.WriteLine("Введите число от 10 до 999");
int num = int.Parse(Console.ReadLine ()!);     
int result=ThirdDigit(num);
    if (result!=-1){
    
    Console.WriteLine(result);
    }else Console.WriteLine("ошибка");
    

