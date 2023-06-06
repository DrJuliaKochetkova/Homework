// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int a = Prompt("Введите число А: ");
int b = Prompt("Введите число B: ");


void FindPow(int a, int b)
{
    double d = Math.Pow(a,b);
    Console.WriteLine("Число А в степени В равно: " + d);
}

FindPow(a,b);

// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)