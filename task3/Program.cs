//Напишите программу, которая на вход принимает число и выдает, является ли оно четным

Console.WriteLine("Введите число");
int number=int.Parse(Console.ReadLine()!);

if((number%2)==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}