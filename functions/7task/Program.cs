//Заполните массив на N (вводится с консоли, не более 8)
//случайных целых чисел от 0 до 9. 


int[] GetDigitsArray()
{
    System.Console.Write("enter the size of the array <= 8: ");
    int size = int.Parse(System.Console.ReadLine()!);
    int[] array = new int[size];
    Random rnd = new Random();
    int minValue = 0;
    int maxValue = 9;
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("массив [ ");
    foreach (int number in array)
    {
        System.Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

int ConvertDigitToInt(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int tmpResult = array[i] * (int)Math.Pow(10, array.Length -i -1);
        System.Console.Write($"{tmpResult }");
        res+= tmpResult;    
    }
    return res;
}


int[] array = GetDigitsArray();
PrintArray(array);
System.Console.WriteLine($" result = {ConvertDigitToInt(array)}");