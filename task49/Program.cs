// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int[,] array = GetArray(rows, columns);
PrintArray(array);

FindDouble(array);
Console.WriteLine();
PrintArray(array);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindDouble(int [,] a)
{
        for (int i = 0; i < a.GetLength(0); i+=2)
    {
        for (int j = 0; j < a.GetLength(1); j+=2)
        {
            a[i, j] = a[i,j]*a[i,j];
        }
    }
}

// for (row = 0 ; row < matr.GetLength(0) ; row ++)
// {
// for (col = 0 ; col<matr.GetLength(1) ; col ++)
// {
// if (row%2==0 && col%2==0)
// {
// temp=matr[row,col]*matr[row,col];
// matr[row,col]=temp;
// }
// }
// }