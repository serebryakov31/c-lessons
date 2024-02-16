/*

показ общей длины матрицы и колличества и размера строк.

System.Console.WriteLine(table.Length);
System.Console.WriteLine(table.GetLength(0));
System.Console.WriteLine(table.GetLength(1));

*/

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

//суммирует все элементы двумерного массива

int sum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    return sum;
}

System.Console.WriteLine();
int[,] array = GetMatrix(2, 3);
int[,] array1 = GetMatrix(4, 7);

PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine();

PrintArray(array1);

System.Console.WriteLine();

System.Console.WriteLine(sum(array));

System.Console.WriteLine();

System.Console.WriteLine(sum(array1));

System.Console.WriteLine();


