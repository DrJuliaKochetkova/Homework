//Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

Console.WriteLine("Введите 3 числа");
int number1=int.Parse(Console.ReadLine()!);
int number2=int.Parse(Console.ReadLine()!);
int number3=int.Parse(Console.ReadLine()!);
int max= number1;

if (number2>max)
{
    max=number2;
}
if (number3>max)
{
    max=number3;
}
Console.Write("max= ");
Console.WriteLine(max);