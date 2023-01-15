// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree (int a, int b)
{
    int output = a;

    for (int i = 1; i < b; i++)
        output = output*a;
    return output;
}
//System.Console.WriteLine(Degree(2,4));

// ===============================================================================================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int n)
{   
    int sum = 0;
    while (n != 0)
    {
        sum = sum + (n % 10);
        n = n / 10;
    }
    return sum;
}
//System.Console.WriteLine(Sum(82));

// =================================================================================================================================

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void RandomArray ()
{
    int[] arr = new int[8];
    Random rnd = new Random();
    
    for (int i = 0; i < 8; i++)
        {
        arr[i] = rnd.Next(0,100);
        if (i == 0) System.Console.Write("[");
        System.Console.Write(arr[i]);
        if (i < 7) System.Console.Write(", ");
        if (i == 7) System.Console.Write("]");
        }
       
}

RandomArray();