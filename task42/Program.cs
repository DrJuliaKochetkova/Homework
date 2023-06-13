// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InPutNum(string message) // ввод данных
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int a = InPutNum("Введите число");
int res = 0;
string showresult = string.Empty;
while (a > 0)
{
res = a % 2;
a /= 2;
showresult = res + showresult;
}
Console.WriteLine();
Console.WriteLine(showresult);

// string res1=Convert.ToString(number,2); - для вычисления задачи в одну строку

// int InPutNum(string message) // ввод данных
// {
// Console.WriteLine(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// void Convert10To2(int num)
// {
// int res = 0;
// string showresult = string.Empty;
// while (num > 0)
// {
// res = num % 2;
// num /= 2;
// showresult = res + showresult; // 0 + "пустое значени" // 1+0 //
// }
// Console.WriteLine();
// Console.WriteLine(showresult);

// }

// int a = InPutNum("Введите число");
// Convert10To2 (a);