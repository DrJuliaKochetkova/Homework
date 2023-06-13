// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray (int size)
{
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(0,200);
        Console.Write($"{res[i]} ");

    }
    return res;
}




void FindSum (int[] array)
{
    int summDigit = 0;
    for (int i = 0; i < array.Length; i++)
    
    {        
        if (i%2 == 0)
        {
            Console.WriteLine(" ");
        }
        else
        {
            summDigit = summDigit +array[i];
        }
    }
        Console.WriteLine ($"Сумма чисел на нечетных позициях равна: {summDigit} ");

}

int[] massiv = GetArray(10);
    Console.WriteLine(" ");
FindSum(massiv);