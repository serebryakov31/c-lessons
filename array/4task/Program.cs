int n = 10;
int[] array = { 2, 3, 4, 7, 8, 1, 12, 15, 22, 6 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);

//   j++; ===  j=j+1;
// нашли наибольший элемент массива