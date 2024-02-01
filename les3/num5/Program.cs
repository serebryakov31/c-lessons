
// int a = 5; 
// Console.WriteLine("Hello, " + a + "!");
// Console.WriteLine("Hello, name");
// Console.WriteLine($"Hello, {a}");

int num = 4545458;
int firstnum = num / 100;
if (num / 100 != 0)
{
    Console.Write(firstnum % 10);
}
else
{
    Console.Write("Третьей цифры нет");
}