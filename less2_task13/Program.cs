// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int numIN = System.Convert.ToInt32(System.Console.ReadLine());
string numOut = System.Convert.ToString(numIN);
if (numOut.Length < 3) 
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    numOut = numOut.Substring(2,1);   
    System.Console.WriteLine(numOut);
}
