// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, 
// b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите b1: ");
double b1 = Double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Double.Parse(Console.ReadLine());
void IDontKnowHowNamedThisMethod (double x1,double y1, double x2, double y2)
{
    double x = (x2 - x1) / (y1 - y2);
    double y = y1 * x + x1;
    Console.WriteLine("(" + Math.Round(x, 2) + "; " + Math.Round(y, 2) + ")");
}
IDontKnowHowNamedThisMethod(b1,k1,b2,k2);