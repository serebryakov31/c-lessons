//меняем значение элементов массива на противоположное

System.Console.Write("Введите размер массива ");

int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];

System.Console.WriteLine($"Введите {size} элементов массива:");

for (int i = 0; i < size; i++)

{
    int input = int.Parse(Console.ReadLine()!);
    numbers[i] = input;
}
System.Console.WriteLine("новый массив: ");
for (int j = 0; j < numbers.Length; j++)
{
    numbers[j] = -numbers[j];
    System.Console.Write(numbers[j] + " ");
}