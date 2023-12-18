//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/*char[,] charArray = {{'a','v','d'},{'s','h','s'},{'q','p','o'}};

string str = string.Empty;
for (int i = 0; i < charArray.GetLength(0); i++)
{
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
        str += charArray[i,j];
    }
}
Console.WriteLine(str);*/



//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

/*string str = "AkUIKKIiiiasaPP";
string result = str.ToLower();
Console.WriteLine(result);*/

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

/*string str = Console.ReadLine();
char[] result= new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
        result[i] = str[(str.Length-1)-i];
}
string str1 = string.Concat(result);
if (str1 == str)  Console.WriteLine("Строка палиндром");
else Console.WriteLine("Строка не палиндром");*/

//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
string str = "First Second thrid";
string [] strArray = str.Split(" ");
int count = strArray.Length -1;
for (int i = 0; i < strArray.Length/2; i++)
{
    string temp =strArray[i];
    strArray[i] = strArray[count-i];
    strArray[count-i] = temp;
    count--;
}
string result = string.Join(" ",strArray);
Console.WriteLine(result);