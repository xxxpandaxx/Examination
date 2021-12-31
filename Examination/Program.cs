int[] arr = new int[6];
void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}
void UserNumber(int[] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine() + " ");
    }
}
void EvenNumbers(int[] array)
{
 for (int i = 0; i < array.Length;i++)
 {
     if ( array[i]%2 == 0 )
     {
        Console.Write(array[i] +" ");
     }
 }

}

PrintArr(arr);
Console.WriteLine();
UserNumber(arr);
Console.WriteLine();
PrintArr(arr);
Console.WriteLine();
EvenNumbers(arr);