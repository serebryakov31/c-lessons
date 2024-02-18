/*

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n * Fact(n-1);
}

System.Console.WriteLine(Fact(0));

//////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////

void MyFunc(int n)
{
    System.Console.WriteLine($"Myfunc {n} Start");
    if (n > 1)
    {
        MyFunc(n-1);
    }
    System.Console.WriteLine($"Myfunc {n} End");
}

MyFunc(9);

*/

////////////////////////////////////////////////////


/// Напишите программу, которая будет принимать на вход число и
/// возвращать сумму его цифр.


/*
int SumOfDigits(int value)
{
    if (value == 0)
    {
        return 0;
    }
    int sum = value % 10 + SumOfDigits(value / 10);
    return sum;
}

System.Console.WriteLine($"Введите число");
int n = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine(SumOfDigits(n));
*/

///////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////

/*
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.
*/

void FromOneToN(int n)
{
    if (n > 1)
    {
        FromOneToN(n - 1);
    }
    System.Console.WriteLine(n);
}

FromOneToN(8);