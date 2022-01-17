// int[] arr = new int[6];
// void PrintArr(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//     Console.Write(array[i] + " ");
//     }
// }
// void UserNumber(int[] array)
// {
//     for (int i = 0; i < array.Length;i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine() + " ");
//     }
// }
// void EvenNumbers(int[] array)
// {
// int count = 0;
//  for (int i = 0; i < array.Length;i++)
//  {
     
//      if ( array[i]%2 == 0 )
//      {
//         Console.Write(array[i] +" ");
//         count++;
//      }
//  }
//     if (count == 0)
//     {
//         Console.WriteLine("There is no even numbers");
//     }
// }

// PrintArr(arr);
// Console.WriteLine();
// UserNumber(arr);
// Console.WriteLine();
// PrintArr(arr);
// Console.WriteLine();
// EvenNumbers(arr);

int[] arr1 = new int[5];
int[] arr2 = new int[arr1.Length];


void UserNumber(int[] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine() + " ");
     }
}
void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}

void CreateEvenArray(int[] arr01, int[] arr02)
{
    for(int i = 0; i < arr01.Length;i++)
    {
        if (arr01[i]%2==0)
        {
            arr02[i] = arr01[i];
            Console.Write(arr2[i]+" ");
        }
    }
}

UserNumber(arr1);
PrintArr(arr1);
Console.WriteLine();
CreateEvenArray(arr1,arr2);
