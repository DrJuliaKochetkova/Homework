// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray (int size)
{
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(100,1000);
        Console.Write($"{res[i]} ");

    }
    return res;
}

void FindCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i]%2 == 0)
        {
            count += 1;
        }
    }
        Console.WriteLine ($"Количество четных чисел в массиве равно: {count} ");

}

int[] massiv = GetArray(8);
    Console.WriteLine(" ");
FindCount(massiv);