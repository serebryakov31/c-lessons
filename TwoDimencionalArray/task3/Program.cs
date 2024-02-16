string str = "Hello world";

System.Console.Write(str);

char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };

string str2 = new String (ch_array);
System.Console.WriteLine();
System.Console.Write(str2[1]);
System.Console.Write(str2[3]);
System.Console.Write(str2[4]);

string str3 = new String ('f', 6); // буква и колличество повторений
System.Console.WriteLine();
System.Console.WriteLine(str3);

/*
Contains Определяет, содержится ли подстрока в строке

EndsWith Определяет, совпадает ли конец строки с подстрокой

IndexOf Находит индекс первого вхождения символа или подстроки в
строке

Insert Вставляет в строку подстроку

Replace Замещает в строке символ или подстроку другим символом или
подстрокой
*/ 
