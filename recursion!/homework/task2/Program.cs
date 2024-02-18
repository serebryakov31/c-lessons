int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return (N + 1);
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }

}

Console.Write($"Введите неотрицательные числа M и N: ");
int M = Convert.ToInt32(Console.ReadLine()!);
int N = Convert.ToInt32(Console.ReadLine()!);

if (M >= 0 && N >= 0)
{
    System.Console.WriteLine($"A({M},{N}) = {Akkerman(M, N)}");
}
else
{
    System.Console.WriteLine("Введены неверные значения");
}