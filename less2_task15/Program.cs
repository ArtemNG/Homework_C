// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int numIN = System.Convert.ToInt32(System.Console.ReadLine());
if (numIN < 8 && numIN > 0)
{
    if (numIN == 6 || numIN == 7)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Это не день недели!");
}