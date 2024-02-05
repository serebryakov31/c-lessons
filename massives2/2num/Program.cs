System.Console.Write("Введите размер массива ");

int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];

System.Console.WriteLine($"Введите {size} элементов массива:");

for (int i = 0; i < size; i++)

{
    int input = int.Parse(Console.ReadLine()!);
    numbers[i] = input;
}

System.Console.WriteLine("массив: ");

for (int i = 0; i < numbers.Length; i++)

{
    System.Console.Write(numbers[i] + " ");
}

System.Console.Write($"Введите число для проверки наличия в массиве ");

int digit = int.Parse(Console.ReadLine()!);

bool result = false;

for (int j = 0; j < numbers.Length; j++)
   
    {
        if (numbers[j] == digit)
        {
        result = true;
        break;
        }    
    }

if (result == true)

{
System.Console.Write(digit + " является элементом массива ");
}

else

{
System.Console.Write(digit + " не является элементом массива ");
}