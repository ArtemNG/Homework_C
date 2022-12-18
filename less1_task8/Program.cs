// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number = Convert.ToInt32(System.Console.ReadLine());

for (int index=1; index<=number; index++)
{
    if (Math.IEEERemainder(index,2) == 0)
    {
        System.Console.Write(index+" ");
    }
}