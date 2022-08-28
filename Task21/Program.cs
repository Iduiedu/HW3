// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки: x1");
        double x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("y1");
        double у1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("z1");
        double z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки: x2");
        double x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("y2");
        double у2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("z2");
        double z2 = Convert.ToInt32(Console.ReadLine());
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(у2 - у1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine("Расстояние между точками равно " + distance);
    }




}
