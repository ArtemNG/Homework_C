// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Formula (double ax, double ay, double az, double bx, double by, double bz)
{
    double sum = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
    return Math.Round(sum,2);   
}
System.Console.WriteLine("Введите координаты точки А");
var dotA = (x:System.Convert.ToDouble(System.Console.ReadLine()),
            y:System.Convert.ToDouble(System.Console.ReadLine()),
            z:System.Convert.ToDouble(System.Console.ReadLine()));
System.Console.WriteLine("Введите координаты точки В");
var dotB = (x:System.Convert.ToDouble(System.Console.ReadLine()),
            y:System.Convert.ToDouble(System.Console.ReadLine()),
            z:System.Convert.ToDouble(System.Console.ReadLine()));
System.Console.Write("Расстояние между точками = ");            
System.Console.Write(Formula(dotA.x, dotA.y, dotA.z, dotB.x, dotB.y, dotB.z));