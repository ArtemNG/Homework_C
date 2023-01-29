// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] RandomArrayDouble2D (int rows, int col)
{
    double[,] arr = new double[rows,col];
    Random rnd = new Random();
    
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arr[i,j] = Math.Round(rnd.NextDouble() * 10, 1);
            }
        }      
    return arr;   
}

void PrintArray2D(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}

int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// int rows = InputNumber("Введите количество строк");
// int columns = InputNumber("Введите количество столбцов");
// PrintArray2D(RandomArrayDouble2D(rows, columns));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void ElementPosition (int rows, int col, double[,] arr)
{
    if (rows - 1 > arr.GetLength(0) || col - 1 > arr.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента нет");
        
    }
    else
    {
        System.Console.WriteLine("Значение ячейки: " + arr[rows-1,col-1]);
    }
}

// int rows = InputNumber("Введите номер строки");
// int columns = InputNumber("Введите номер столбца");
// double[,] arr = RandomArrayDouble2D(10,10);
// PrintArray2D(arr);
// ElementPosition(rows,columns, arr);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] RandomArrayInt2D (int rows, int col)
{
    int[,] arr = new int[rows,col];
    Random rnd = new Random();
    
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arr[i,j] = rnd.Next(0,100);
            }
        }      
    return arr;   
}

void PrintArrayInt2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}

void Average (int[,] arr)
{
    double sum;
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j,i];            
        }
        System.Console.Write(Math.Round(sum / arr.GetLength(0), 1) + " | ");
    }    
}


int[,] arr = RandomArrayInt2D(5,3);
PrintArrayInt2D(arr);
Average(arr);