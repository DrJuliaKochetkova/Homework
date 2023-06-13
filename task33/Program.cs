// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] massiv = { 6, 7, 19, 345, 3 };
void FindNum(int[] array, int x)
{
    int i = 0;
    int length = array.Length;
    bool flag = false;
    while (i < length)
    {

        if (x == array[i])
        {
            flag = true;
        }
        i++;
    }
    if (flag)
    {
        Console.WriteLine($"Цифра {x} имеется в массиве");

    }
    else
    {
        Console.WriteLine($"Цифра {x} нет в массиве");
    }
}
Console.WriteLine(string.Join(", ", massiv));
FindNum(massiv, 345);