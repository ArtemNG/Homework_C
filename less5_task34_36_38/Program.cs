// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray (int size, int rangeX, int rangeY)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
        arr[i] = rnd.Next(rangeX,rangeY);
              
    return arr;   
}


int ParityCounter (int[] arr)
{
    int count = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i]%2 == 0) count++;
    }
    return count;
}
// int[] arr = RandomArray(10,100,1000);
// System.Console.WriteLine("[{0}]", String.Join(",", arr));
// System.Console.WriteLine(ParityCounter(arr));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int SummOddIndex (int[] arr)
{
    int sum = 0;
    int size = arr.Length;
    for (int i = 1; i < size;)
    {
        sum = sum + arr[i];
        i += 2;
    }
    return sum;
}
// int[] arr = RandomArray(20,-100,100);
// System.Console.WriteLine("[{0}]", String.Join(",", arr));
// System.Console.WriteLine(SummOddIndex(arr));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int DifferenceMaxMin (int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    
    return max-min;
}
// int[] arr = RandomArray(10,-100,100);
// System.Console.WriteLine("[{0}]", String.Join(",", arr));
// System.Console.WriteLine(DifferenceMaxMin(arr));

