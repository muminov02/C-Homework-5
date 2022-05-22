void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int[] NewArray(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] array = new int[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            array[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        return array;
    }
    else
    {
        int[] array = new int[arr.Length / 2 + 1];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            array[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        array[array.Length-1] = arr[arr.Length / 2];
        return array;
    }


}

int[] arr_1 = MassNums(11);
Print(arr_1);
Print(NewArray(arr_1));
