string[] M;
Console.WriteLine("Введите массив строк через запятую");
string stroka = Console.ReadLine();
M = stroka.Split(',');
var result = new string[M .Length];
var realSize = 0;