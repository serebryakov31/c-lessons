int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив

int temp;

Console.Write("Исходный массив: "); // Вывод исходного массива

foreach (int number in numbers)

{
    Console.Write(number + " ");
}

for (int i = 0; i < numbers.Length / 2; i++) // Реверсирование массива

{
    temp = numbers[i]; // Меняем местами элементы
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

Console.Write("отраженный массив: "); // Вывод измененного массива

foreach (int number in numbers)
{
    Console.Write(number + " ");
}

