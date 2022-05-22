void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void CheckArray(int[] arr){
    int max = arr[0];
    int min = arr[0];
    int diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
        if(arr[i]<min) min = arr[i];
        diff = max-min;
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
    Console.WriteLine($"Минимальным элемент массива: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}");
}

int[] arr_1 = CreateArray(11);
PrintArray(arr_1);
CheckArray(arr_1);