// 



int[] arr = GetRandomArray(10);
PrintArray(arr);

Console.WriteLine(GetSumMoreZero(arr));
Console.WriteLine(GetSumLessZero(arr));

int GetSumMoreZero(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            result += arr[i];
        }
    }
    return result;
}

int GetSumLessZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result += arr[i];
        }
    }
    return result;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-20, 21);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}