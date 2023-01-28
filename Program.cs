// Найти максимальное повторение "1" в массиве
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
    array[i] = new Random().Next(0,2);
}
void PrintMas(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
PrintMas(array);
int FindMaxCount(int[] arr)
{
    int result = 1;
    int count = 1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i+1] && arr[i] == 1)
        {
            count++;
            if (count > result) result = count;
        }
        else count = 0;
    }
    return result;
}
Console.WriteLine(FindMaxCount(array));
