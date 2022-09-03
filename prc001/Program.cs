//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456-> 6
//782-> 2
//918-> 8

int Prompt(string message)
{
   Console.Write(message);               //вывод приглашения.
   string strValue;                      //обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; //вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      //преоброзование строки в целое число.
   return value;
}

int a = Prompt("Введите трехзначное число >");
if (a < 1000 && a > 99)
{
   int result = a % 10;
   System.Console.WriteLine(result);
}
else
{
   System.Console.WriteLine("Ввели не трёхзначное число.");
};