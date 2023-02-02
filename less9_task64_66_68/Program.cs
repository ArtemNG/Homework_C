// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Num(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        Num(n - 1);
    }
}

// Num(8);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumMN(int m, int n)
{
    int sum = m;
    for (int i = ++m; i <= n; i++)
    {
        sum += i;
        SumMN(++m, n);
    }
    return sum;

}
//System.Console.WriteLine(SumMN(1,15));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akk (int m, int n)
{
    if (m == 0) return n + 1;

    if (n == 0) return Akk(m - 1, 1);

    return Akk(m - 1, Akk(m, n - 1));
}

System.Console.WriteLine(Akk(3,2));