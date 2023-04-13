Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int n){
int result = 1;
int i = 2;
if( n < 0){
    i = n;
    n = -1;
}
for (; i <= n; i++){
    result *= i;
}
return result;
}