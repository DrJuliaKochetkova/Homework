// Напишите задачу, которая принимает на вход число и выдает количество цифр в числе

// int num = Prompt("Введите число N ");
// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int count = 0;
// while (num!=0)
// {
//     num = num/10;
//     count++;
// }

// Console.Write(count);

int num = Prompt("Введите число N ");
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int CountDigit(int num)
{
    int count = 0;
    while (num!=0)
    {
      num = num/10;
      count++;
    }
    return count;
}

Console.WriteLine($"Количество цифр равно: {CountDigit(num)}");