void CreateRange(int N, int M)
{
    if (M > N)
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write($"{M} ");
    CreateRange(N, M + 1);
}

System.Console.WriteLine("Задайте значения промежуток от M до N");
int M = Convert.ToInt32(Console.ReadLine()!);
int N = Convert.ToInt32(Console.ReadLine()!);
CreateRange(N, M);