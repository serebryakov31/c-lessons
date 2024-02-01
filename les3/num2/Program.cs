int a = 974;
int seconddigit = (a % 100 )/10;
int lastdigit = a%10;
double result = Math.Pow(seconddigit, lastdigit);
Console.WriteLine(result);
// math.pow считает целые и дробные,
// поэтому переменная double