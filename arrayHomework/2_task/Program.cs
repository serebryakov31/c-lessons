int count = 0;
int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int i = 0;
    while (i<10)
    {
        if (array[i] %2 == 0)
        {
        count = count+1;
        }     
        i++;
    } 
    
System.Console.WriteLine(count);
    