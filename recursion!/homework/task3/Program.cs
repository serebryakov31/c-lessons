System.Console.Write("Введите размер массива ");

int size = int.Parse(Console.ReadLine()!);

int[] CreateArray()
{
    int[] numbers = new int[size];

    System.Console.WriteLine($"Введите {size} элементов массива:");
    for (int i = 0; i < size; i++)
    {
        int input = int.Parse(Console.ReadLine()!);
        numbers[i] = input;
    }
    return numbers;
}

int[] arr=CreateArray();

void ShowElementsInReverse(int[] array, int size)
{
    if (size >= 1)
    {
        Console.Write($"{array[size-1]} ");
        ShowElementsInReverse(array, size-1);
    }
    return;
}

ShowElementsInReverse(arr, size);