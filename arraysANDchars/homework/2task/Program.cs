// String.ToLower/Upper Методы замены в стринг строчных на Заглавные и наоборот

Console.Write("Введите строку, содержащую латинские буквы в обоих регистрах ");
string str = Console.ReadLine()!;
Console.WriteLine($"введена строка: {str}");
string Lowerstring = str.ToLower();
System.Console.WriteLine("новая строка: " + Lowerstring);

Console.Write("Введите строку, содержащую латинские буквы в обоих регистрах ");
string str2 = Console.ReadLine()!;
Console.WriteLine($"введена строка: {str2}");
string Upperstring = str2.ToUpper();
System.Console.WriteLine("новая строка: " + Upperstring);