/*

Console.WriteLine("кол-во чисел: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
for (int i = 0; i < size; i++)
{
    numbers[i] =int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);
    if (i < numbers.Length -1)
    {
        System.Console.Write(", ");
    }
}

*/
//string input = Console.ReadLine()!;
string input = "1, 3, 4, 5, 6";
int[] numbers = input.Split(", ").Select(x => int.Parse(x)).ToArray();

System.Console.WriteLine(string.Join("; ", numbers));
