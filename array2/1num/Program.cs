System.Console.Write("Введите размер массива ");

// int.Parse преобразует строчное значение в конкретное число
// строка 12345 становится числом 12 тысяч 345

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