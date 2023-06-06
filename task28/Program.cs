// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetFactorial (int number)
{
    int factorial = 1;
    for (int i = 1; i < number; i++)
    {
        factorial = factorial*i;
        Console.Write(factorial + " ");
    }
    return factorial;
}
int num = Prompt(" Введите число: ");
Console.WriteLine($"Произведение чисел равно = {GetFactorial(num)}");