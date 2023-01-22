// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] EnteringNumbers ()
{
    System.Console.WriteLine("Введите числа через пробел: ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    return arr;
}

int Counter (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
//System.Console.WriteLine(Counter(EnteringNumbers()));


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint ()
{
    System.Console.Write("Введите b1: ");
    double b1 = System.Convert.ToDouble(System.Console.ReadLine());
    System.Console.Write("Введите k1: ");
    double k1 = System.Convert.ToDouble(System.Console.ReadLine());
    System.Console.Write("Введите b2: ");
    double b2 = System.Convert.ToDouble(System.Console.ReadLine());
    System.Console.Write("Введите k2: ");
    double k2 = System.Convert.ToDouble(System.Console.ReadLine());

    double x = (b1 - b2) / (k2 - k1);
    double y = ((k2 * b1) - (k1 * b2)) / (k2-k1);
    System.Console.WriteLine($"Точка пересечения ({x};{y})");
}
// IntersectionPoint();
