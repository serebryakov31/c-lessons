
System.Console.Write("Введите размер массива ");

int size = int.Parse(Console.ReadLine()!);

int[] array = new int[size];

System.Console.WriteLine($"Введите {size} элементов массива:");

for (int i = 0; i < size; i++)

{
    int input = int.Parse(Console.ReadLine()!);
    array[i] = input;
}

//int[] array = {1, 2, 3, 4, 5, 6};
int n = array.Length -1; //(5)индекс последнего элемента массива, т к массив идет от 0, а не от 1
int[] result = new int [array.Length / 2]; //новый массив короче х2
for (int i = 0; i < n-i; i++) // до тех пор, пока повторений меньше 4
                              
{
    result[i] = array[i] * array[n-i]; // result[0] = array[0]*array[5] == 6; | result[1] = array[1]*array[4] == 10 | result[2] ==12
}
for (int i = 0; i < result.Length; i++) //result[0] + result[1] + result[2] == 6 10 12
{
    System.Console.Write(result[i]+" ");
}
