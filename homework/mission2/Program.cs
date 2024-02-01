Console.Write("Введите значение по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0)
{
    if (y>0)
    {
    Console.Write("первая четверть");   
    }
    else if (y<0)
    {
        Console.Write("четвертая четверть");
    }
    else
    {
         Console.Write("значение y не принимается");
    }
}
else if (x<0) 
{
    if (y>0)
    {
      Console.Write("вторая четверть");   
    }
    else if (y<0)
    {
        Console.Write("третья четверть");
    }
    else
    {
         Console.Write("значение y не принимается");
    }
}
else
{
Console.Write("значение x не принимается");   
}