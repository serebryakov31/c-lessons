Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
Console.WriteLine($"введена строка: {str}");

bool isPalindrome = IsPalindrome(str);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");

bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}
