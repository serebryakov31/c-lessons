//создание рандомного массива с указанием размера и диапозона
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

//функция на показ массива
void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int number in array)
    {
        System.Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

//функция на проверку на простое число
bool IsPrime(int number) 
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

//создание массива через консоль
int[] GetArrayFromConsole()
{
    System.Console.Write("size: ");
    int size = int.Parse(System.Console.ReadLine()!);
    int[] array = new int[size];

    System.Console.WriteLine($"Enter {size} elements: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(System.Console.ReadLine()!);
    }
    return array;
}

//подсчет простых чисел в массиве
int CountPrimeNumbers(int[] array)
{
    int count = 0;
    foreach (var element in array)
    {
        if (IsPrime(element))
        {
            count++;
        }
    }
    return count;
}

int[] array = GetRandomArray(10, 1, 99);
PrintArray(array);
System.Console.WriteLine($"количество простых чисел: {CountPrimeNumbers(array)}");

int[] array2 = GetArrayFromConsole();
PrintArray(array2);
System.Console.WriteLine($"количество простых чисел: {CountPrimeNumbers(array2)}");

