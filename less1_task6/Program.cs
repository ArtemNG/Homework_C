// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = Convert.ToInt32(System.Console.ReadLine());

if (Math.IEEERemainder(number,2) == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}

