//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write ("n= ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("For: ");
for (int i=1; i<=n; i++)
{
    if ((i%2)==0) Console.WriteLine(i);
}
Console.WriteLine();