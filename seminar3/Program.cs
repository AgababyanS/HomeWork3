Console.WriteLine("Напишите номер четверти");
int a = int.Parse(Console.Readline());
Console.WriteLine("x");
int x = int.Parse(Console.Readline());
Console.WriteLine("y");
int y = int.Parse(Console.Readline());
if (a==1){
Console.WriteLine(x>0 && y>0);
}if (a==2){
Console.WriteLine(x<0 && y>0);
}else if (a==3){
Console.WriteLine(x<0 && y<0);
}else if (a==4)
Console.WriteLine(x>0 && y<0);

