// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] Massive(int size, int minValue, int maxValue)
//   {
//   int[] res = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//      res[i] = new Random().Next(minValue, maxValue + 1);
//      Console.Write($"{res[i]} ");

//   }
//   return res;
// }

// void ChangeNum2(int[] array)
// {
//    int i = 0;
//     foreach (int el in array)
//     {

//       array[i] = el*(-1);
//       Console.Write($"{array[i]} ");
//       i++;
//       
//     }
// }    
//    
//   }

// }

// int [] xyz = Massive(12,-9,9);
// Console.WriteLine();
// ChangeNum2(xyz);


int[] Massive(int size, int minValue, int maxValue)
  {
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
     res[i] = new Random().Next(minValue, maxValue + 1);
     Console.Write($"{res[i]} ");

  }
  return res;
}

void ChangeNum(int[] array)
{
  foreach (int el in array)
  {
    Console.Write($"{el*(-1)} ");
  }

}

int [] xyz = Massive(12,-9,9);
Console.WriteLine();
ChangeNum(xyz);