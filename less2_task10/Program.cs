// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int numIN = 397; 
string numOut = System.Convert.ToString(numIN);
numOut = numOut.Substring(1,1);
System.Console.WriteLine(numOut);
