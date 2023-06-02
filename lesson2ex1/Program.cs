// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int FindFirstDigit(int num)
// {
//     int firstNumber = num/10;
//     return firstNumber;
// }

// int FindSecondDigit(int firstNumber)
// {
//     int secondNumber = firstNumber%10;
//     return secondNumber;
// }

// int number = new Random().Next(100,1000);
// int firstDigit = FindFirstDigit(number);
// int secondDigit = FindSecondDigit(number);

// Console.WriteLine("Рандомное число: " + number);
// Console.WriteLine(secondDigit);

// Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }

    // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}