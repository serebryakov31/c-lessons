
string GetLettersFromString(string s)
{
    string Letters = "";
    foreach (char e in s)
    {
      if (char.IsAsciiLetter(e) == true)
      {
      Letters = Letters + e;
      }
    }
    return Letters;
}
System.Console.WriteLine("Введите текст ");
string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);
