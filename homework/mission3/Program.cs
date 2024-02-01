Console.Write("Введите число от 10 до 99 ");
int number = Convert.ToInt32(Console.ReadLine());
int firstnumber = number/10;
int secondnumber = number%10;
if (firstnumber > secondnumber)
{
    Console.Write(firstnumber);
}
else
{
    Console.Write(secondnumber);
}