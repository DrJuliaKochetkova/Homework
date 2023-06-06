// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int num = Prompt("Введите число N ");
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SummDigit(int number)
{
    int sum = 0;
    for (int i = 1; number>0; i++)
    {
        int digit = number%10;
        number = number/10;
        sum = sum+digit;
        Console.Write(sum + " ");
    }
    return sum;
}

Console.WriteLine($"Сумма всех чисел равна: {SummDigit(num)}");