// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int numIN = System.Convert.ToInt32(System.Console.ReadLine());
int i = 0;
int j = 1;
string num = System.Convert.ToString(numIN);

while (num.Length > i)
{   
    if (num[i].ToString() != num[^j].ToString())
    {
        System.Console.WriteLine("Нет!");
        return;
    }
  
    i++;
    j++;
}
System.Console.WriteLine("Палиндром");
