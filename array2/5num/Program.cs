/*
int[] array = {1, 2, 3, 4, 5, 6, 7};

for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]} {array[array.Length-1-i]}");
}
*/

int count = 0;
int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int i = 0;
int min = 10;
int max = 90;
    while (i<10)
    {
        if (array[i] >= min & array[i] <= max)
        {
        count = count+1;
        }     
        i++;
    } 
    
System.Console.WriteLine(count);
    