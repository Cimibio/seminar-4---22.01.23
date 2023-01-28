// Дан одномерный массив, написать сколько раз повторяется самое частое число
Console.WriteLine("введите количество элементов массива");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
void FillMas(int[] arr)
{
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        arr[i] = new Random().Next(0,10);
    }
}
FillMas(array);

void PrintMas(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
PrintMas(array);

int findNumber(int[] arr)
{
    int result = 1;
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        count = 1;
        for (int j = i +1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
                if (count > result) result = count;
            }
        }
    }
    return result;
}
Console.WriteLine(findNumber(array));   