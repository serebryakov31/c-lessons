Random rnd = new Random();
int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 100);
    System.Console.Write(arr_int[i] + " ");
    i++;
}


// в этой функции проверяется число на простоту. оно последовательно делится 
// на 2, 3, 4, 5, .... number -1. если на какой-нибудь цифре в промежутке
// деление происходит без остатка. значит число делится не только на 1 и себя.
// но и на другие числа, следовательно оно не простое
bool IsPrime(int number) 
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
// foreach последовательно перебирает все элементы массива.
int count = 0;
foreach (var e in arr_int)
{
    if (IsPrime(e)) //вызываем функцию выявления простого числа для каждого элемента массива
    { 
        count++; // если оно возвращает правду, то он IsPrime => count++
    }
}
System.Console.WriteLine($"простых чисел: {count}");
