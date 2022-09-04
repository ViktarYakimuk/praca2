// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int Prompt(string message)
{
   Console.Write(message);               //вывод приглашения.
   string strValue;                      //обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; //вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      //преоброзование строки в целое число.
   return value;
}


System.Console.WriteLine("Введите число->");
int a = int.Parse(Console.WriteLine()!);
bool remains = (a % 7 == 0) && (a % 23 == 0);

if (remains)
{
   Console.WriteLine("Кратно");
}
else
{
   Console.WriteLine("Не кратно");
}