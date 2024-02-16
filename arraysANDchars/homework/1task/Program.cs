string CreateStringFromMatrix(char[,] matrix)
{
    string result = "";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];
        }
    }
    return result;
}

void ShowMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
    }
    System.Console.WriteLine();
}

Console.WriteLine("введите размеры двумерного массива ");
int rows = int.Parse(Console.ReadLine()!);
int cols = int.Parse(Console.ReadLine()!);
char[,] matrix = new char[rows, cols];
Random rnd = new Random();
System.Console.Clear();
System.Console.WriteLine("задан буквенный массив: ");
ShowMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = (char)('a' + rnd.Next(0, 26));
    }
}
foreach (var e in matrix)
{
    System.Console.Write(e + " ");
}
string result = CreateStringFromMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"создана строка: {result}");




