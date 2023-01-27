void task43_DZ()
{
    // Напишите программу, которая найдет точку пересечения двух прямых,
    // заданных уравнениями y=k1*b1, y=k2*x +b2; значения b1,k1,b2,k2 задаются пользователем.

    var (k1, b1) = (1, 6);
    var (k2, b2) = (4, -7);
    double x = Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2);
    x = Math.Round(x, 2);
    double y = k1 * x + b1;
    y = Math.Round(y, 2);
    Console.WriteLine($"Точка пересечения А: {x} и {y}");



}
task43_DZ();