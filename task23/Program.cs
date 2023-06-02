// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Prompt(string message)
// {
//     Console.Write(message);
//     string num = Console.ReadLine()!;
//     // проверка на число
//     if ((int TryParse(num, out int num_n)) == false);
//     {
//         Console.WriteLine("Это не число");
//     }
//     return num_n;
// }

// void PrintDegreeTable(int number)
// {
//     for(int i = 1; i<= number; i++)
//     {
//         Console.Write(Math.Pow(i,3) + " ");
//     }
// }

// int num = Prompt("Введите число N");
// // проверка на знак
// int number = Math.Abs(num);

// PrintDegreeTable(number);

int num = Prompt("Введите число N ");
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintDegreeTable(int number)
{
    for(int i = 1; i<= number; i++)
    {
        Console.Write(Math.Pow(i,3) + " ");
    }
}

// проверка на знак
int number = Math.Abs(num);

PrintDegreeTable(number);