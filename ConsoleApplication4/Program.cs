using System;
namespace Hello
{
class Program
{
static double min(double a, double b)
{
return (a < b) ? a : b;
}
static void Main(string[] args)
{
Console.Write("x=");
double x = double.Parse(Console.ReadLine());
Console.Write("y=");
double y = double.Parse(Console.ReadLine());
double z = min(3 * x, 2 * y) + min(x - y, x + y);
Console.WriteLine("z=" + z);
}
}
}