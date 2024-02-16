
int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];


    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 99);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 4); // создаем матрицу

ShowMatrix(matrix); // выводим элементы исходной матрицы

System.Console.WriteLine(); //обрываем строку

int GetSumOfDigits(int value) // получаем сумму чисел числа с повторяемого сумирования остатка от деления на десять и нового уменьшения числа в 10 раз
{
    int sum = 0;
    while (value>0)
    {
        sum = sum + value % 10;
        value = value / 10;

    }
    return sum;
}

bool IsInteresting(int value) // проверка прохождения условий "интересности". Если сумма чисел кратна 2, выдается правда
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

foreach (int e in matrix) // последовательно выписывает каждый элемент массива соответсвующий IsInteresting
{
    if (IsInteresting(e) == true)
    {
        System.Console.WriteLine(e);
    }
}