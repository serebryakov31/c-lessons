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
    