//Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее

   
Console.WriteLine("Введите 2 числа");
int number1=int.Parse(Console.ReadLine()!);
int number2=int.Parse(Console.ReadLine()!);

if(number1>number2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}