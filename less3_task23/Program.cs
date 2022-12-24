// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = System.Convert.ToInt32(System.Console.ReadLine());

for (int i=1; num >= i; i++)
{
    if (i == num) 
    {
        System.Console.Write(Math.Pow(i,3));  // Чтоб запятую в конце не выводил :D
    }
    else
    {
        System.Console.Write(Math.Pow(i,3)+", ");
    }     
}
