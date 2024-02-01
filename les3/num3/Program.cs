// найти возведение цифры сотен в степень цифры десятков
//  9(7^4)5 
int a = 9745;
int digit = (a % 1000) /100;
int digit2 = (a % 100) /10;
double digit_degree = Math.Pow(digit, digit2);
Console.Write(digit);
Console.Write("^");
Console.Write(digit2);
Console.Write("=");
Console.Write(digit_degree);