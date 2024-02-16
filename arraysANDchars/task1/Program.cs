/*

склеить массив в строку

char[] chars = new char[] { 'a', 'b', 'c', 'd' };

string PrintString(char[] chars)
{
    string sim = "";
    foreach (char e in chars)
    {
        sim = sim + e;
    }
    return sim;
}

string sim = PrintString(chars);
System.Console.WriteLine(sim);
*/

/*  на основе символов строки (тип string) сформировать массив
символов (типа char[]). Вывести массив на экран

*/

/*
string str = "Hello";
char[] MakeCharsArray(string str)
{
    int size = str.Length;
    char[] word = new char[size];
    for (int i = 0; i < str.Length; i++)
    {
        word[i] = str[i];
    }
    return word;
}
char[] word = MakeCharsArray(str);
foreach (char e in word)
{
    System.Console.Write($"{e} ");
}
*/


// посчитать колличесвто глассных в введенном тексте
bool IsVowels(char chr)
{
    return chr == 'a' || chr == 'o' ||
        chr == 'i' || chr == 'e' ||
        chr == 'u' || chr == 'y';
}

int CountVowels(string str)
{
    int vowels = 0;
    foreach (char e in str)
    {
        if (IsVowels(e))
        {
            vowels++;
        }
    }
    return vowels;
}
Console.WriteLine("введите произвольную строку");
string str = Console.ReadLine()!;
int res = CountVowels(str);
Console.WriteLine($"колличество глассных равно: {res}");

