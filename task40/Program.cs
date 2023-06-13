// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int a = Prompt("Введите число А: ");
int b = Prompt("Введите число B: ");
int c = Prompt("Введите число C: ");


void FindTriangle(int a, int b, int c);
if(a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine($"Может существовать ");
}
else
{
    Console.WriteLine($"Не может существовать ");
}

FindTriangle(a,b,c);


// int InPutNum(string message) // ввод данных
// {
// Console.WriteLine(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// int a = InPutNum("введите первую сторону");
// int b = InPutNum("введите первую сторону");
// int c = InPutNum("введите первую сторону");

// if (a<b+c && b<a+c && c<a+b)
// Console.WriteLine($"Такой треугольник существует");
// else Console.WriteLine($"Такой треугольник не существует");


// еще один вариант
// int InPutNum(string message) // ввод данных
// {
// Console.WriteLine(message);
// return Convert.ToInt32(Console.ReadLine());
// }


// void ChekTrueTriangel (int num, int num2, int num3)
// {
// if (num<num2+num3 && num2<num+num3 && num3<num+num2) {
// Console.WriteLine($"Такой треугольник существует");}
// else Console.WriteLine($"Такой треугольник не существует");
// }


// int a = InPutNum("введите первую сторону");
// int b = InPutNum("введите первую сторону");
// int c = InPutNum("введите первую сторону");
// ChekTrueTriangel (a,b,c);
