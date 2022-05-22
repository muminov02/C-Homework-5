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
    int number = 0;
    int number2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) number++;
        else number2++;
    }
    Console.WriteLine($"Чётные числа {number}. Нечётные числа {number2}");
}

int[] arr_1 = CreateArray(11);
PrintArray(arr_1);
CheckArray(arr_1);