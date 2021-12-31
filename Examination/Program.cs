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
