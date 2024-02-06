//Random rnd = new Random();

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    //  arr_int[i] = rnd.Next(1, 100);
    System.Console.WriteLine("введите целочисленный элемент массива: ");
    string input = Console.ReadLine()!;
    arr_int[i]= Convert.ToInt32(input);
    i++;
}

i = 0;
while (i < size)
{
    System.Console.Write($"{arr_int[i]} ");
    i = i + 1;
}