// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] RandomArrayInt2D (int rows, int col)
{
    int[,] arr = new int[rows,col];
    Random rnd = new Random();
    
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arr[i,j] = rnd.Next(0,20);
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
            System.Console.Write(string.Format("{0,5}", array2D[i,j] + " "));
        }
        System.Console.WriteLine();
    }
}

void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
}

// int[,] SortArrayString (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int n = 0; n < array.GetLength(1) - 1; n++)
//       {
//         if (array[i, n] < array[i, n + 1])
//         {
//           int temp = array[i, n + 1];
//           array[i, n + 1] = array[i, n];
//           array[i, n] = temp;
//         }
//       }
//     }
//   }
//   return array;
// }
int[,] SortArrayString (int[,] array)
{
    int[] arrTemp = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                arrTemp[j] = array[i,j];
                if (j == array.GetLength(1)-1)
                {
                    BubbleSort(arrTemp);
                    Array.Reverse(arrTemp);
                    for (int k = 0; k < array.GetLength(1); k++)
                    array[i,k] = arrTemp[k];
                }

            }
            
    }
    return array;
}
// int[,] arr = RandomArrayInt2D(5,5);
// PrintArrayInt2D(arr);
// System.Console.WriteLine();
// PrintArrayInt2D(SortArrayString(arr));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

(int sum, int minString) MinSumString (int[,] array)
{
    int[] arrTemp = new int[array.GetLength(1)];
       
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                arrTemp[i] += array[i,j];
            }
    }

    int minSum = arrTemp[0];
    int minStr = 0;
    
    for (int k = 0; k < array.GetLength(1); k++)
    {    if (arrTemp[k] < minSum) 
        {
            minSum = arrTemp[k];
            minStr = k;
        }
    }
    var result = (sum:minSum, minString:minStr+1);            
    return result;
}

// int[,] arr = RandomArrayInt2D(5,5);
// PrintArrayInt2D(arr);
// var minstr = MinSumString(arr);
// System.Console.WriteLine();
// System.Console.WriteLine("Строка с наименьшей суммой элементов " + minstr.minString + ". Сумма = " + minstr.sum);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MultiplyMatrix (int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0)) return;

    int[,] resultMatrix = new int[arrA.GetLength(1),arrB.GetLength(0)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < arrA.GetLength(1); k++)
                {
                    resultMatrix[i,j] += arrA[i,k] * arrB[k,j];
                }
                
            }
    }
    PrintArrayInt2D(resultMatrix);
}
// int[,] matrixA = RandomArrayInt2D(5,5);
// PrintArrayInt2D(matrixA);
// System.Console.WriteLine();
// int[,] matrixB = RandomArrayInt2D(5,5);
// PrintArrayInt2D(matrixB);
// System.Console.WriteLine();
// MultiplyMatrix(matrixA, matrixB);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] RandomArrayInt3D (int x, int y, int z)
{
    int[,,] arr = new int[x,y,z];
    Random rnd = new Random();
    int[] arrTemp = new int[x*y*z];
    int n = 0;
    for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    arr[i,j,k] = rnd.Next(10,20);
                    arrTemp[n] = arr[i,j,k];
                    n++;
                }
            }
        }
    int a = 0;    
    while(arrTemp.Length > a)
    {    
        
        if (Array.LastIndexOf(arrTemp,arrTemp[a]) != a)
        {
            
            arrTemp[a] = rnd.Next(10,20);
            a = -1;
        }
        a++;
    }
    n = 0;
    for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    arr[i,j,k] = arrTemp[n];
                    n++;
                }
            }
        }
        
    return arr;   
}

void PrintArrayInt3D(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                System.Console.Write(string.Format("{0,13}", arr3D[i,j,k] + $"{(j,k,i)}"));
            }
            System.Console.WriteLine();
        }
        
    }
}

// int[,,] arr = RandomArrayInt3D(2,2,2);
// PrintArrayInt3D(arr);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray(int m, int n)
{
    int s = 1;

    int[,] array = new int[m, n];

    for (int y = 0; y < n; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

    while (s < m * n)
    {
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }

    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
    return array;
}

//PrintArrayInt2D(SpiralArray(4,4));
    