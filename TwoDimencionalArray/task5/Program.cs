// вытаскиваем из рандомного sntring текста цифры и создаем массив из них
string GetDigitsFromString(string s)
{
    string Digits = "";
    foreach (char e in s)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            Digits = Digits + e;
        }
    }
    return Digits;
}

System.Console.WriteLine("Введите текст ");

string str = Console.ReadLine()!;

string OnlydigitsString = GetDigitsFromString(str);

System.Console.WriteLine(OnlydigitsString);

char[] array = OnlydigitsString.ToCharArray();

for (int i = 0; i < OnlydigitsString.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}
