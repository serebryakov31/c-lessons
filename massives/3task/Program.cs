int n = 10;
int[] array = {2,3,4,7,8,1,12,15,22,6};
int i = 0;

while (i<n)
{    
    if (array[i] % 2 == 0)
    {
    System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
// выводит нужные элементы массива.
// в данном случае четные

