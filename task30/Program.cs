// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// void RandomMassive()
// {
//   int[] array = new int [8];
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(0,2);
//    Console.Write (array[i]+ " ");
//  }
// }
// RandomMassive();

void RandomMassive(int val)
{
  int[] array = new int [val];
 for (int i = 0; i < array.Length; i++)
 {
   array[i] = new Random().Next(0,2);
   Console.Write (array[i]+ " ");
 }
}


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    // проверка на число
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число");
    }
    return val;
}
int value = Prompt("Введите число: ");
    RandomMassive(value);