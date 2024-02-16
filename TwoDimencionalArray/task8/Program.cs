// формула создания матрицы
int[,] GetMatrix(int rows, int cols, int minValue = 0, int maxValue = 9)
{
    int[,] table = new int[rows, cols];

    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return table;
}

// формула вывода матрицы в консоле
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

//формула суммирования главной диагонали матрицы
int SumDiag(int[,] arr)
{
    int sum = 0;

    // Math.Min определение минимума
    int minLength = Math.Min(arr.GetLength(0), arr.GetLength(1));
    for (int i = 0; i < minLength; i++)
    {
        sum = sum + arr[i, i];
    }
    return sum;
}




// вводим строки и их длину матрицу
System.Console.Write("Введите колличество строк массива ");

int x = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите колличество элементов в строке массива ");

int y = int.Parse(Console.ReadLine()!);

// создаем матрицу

int[,] arr = GetMatrix(x, y);

System.Console.WriteLine();

// показываем ее в консоли

PrintArray(arr);
System.Console.WriteLine($"сумма элементов главной диагонали равна: {SumDiag(arr)}");



