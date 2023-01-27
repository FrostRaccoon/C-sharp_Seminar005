//



int[] arr = GetRandomArray(10);
PrintArray(arr);
PrintArray(ReplaceNum(arr));

int[] ReplaceNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
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