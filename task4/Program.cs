// Найти расстояние между точками в пространстве 2D/3D

Console.Write("Какое пространство рассматриваем? 2D или 3D?: ");
string place = Console.ReadLine();
if (place.ToLower() == "2d"|place.ToLower() == "3d")
{
if (place.ToLower() == "2d")
{
    Console.Write("Введите координату X1: ");
    int xa=int.Parse(Console.ReadLine());
    Console.Write("Введите координату Y1: ");
    int ya=int.Parse(Console.ReadLine());
    Console.Write("Введите координату X2: ");
    int xb=int.Parse(Console.ReadLine());
     Console.Write("Введите координату Y2: ");
    int yb=int.Parse(Console.ReadLine());
    int result1 = xb-xa;
    int result2 = yb-ya;
    int result3 = result1*result1;
    int result4 = result2*result2;
    int result5 = result3+result4;
    double result6 = Math.Sqrt(result5);
    Console.WriteLine("Расстояние между точками равно " +result6);
}
else
{
    Console.Write("Введите координату X1: ");
    int xa=int.Parse(Console.ReadLine());
    Console.Write("Введите координату Y1: ");
    int ya=int.Parse(Console.ReadLine());
    Console.Write("Введите координату Z1: ");
    int za=int.Parse(Console.ReadLine());
    Console.Write("Введите координату X2: ");
    int xb=int.Parse(Console.ReadLine());
    Console.Write("Введите координату Y2: ");
    int yb=int.Parse(Console.ReadLine());
    Console.Write("Введите координату Z2: ");
    int zb=int.Parse(Console.ReadLine());

    int result1 = xb-xa;
    int result2 = yb-ya;
    int result3 = zb-za;
    int result4 = result1*result1;
    int result5 = result2*result2;
    int result6 = result3*result3;
    int result7 = result4+result5+result6;
    double result8 = Math.Sqrt(result7);
    Console.WriteLine("Расстояние между точками равно " +result8);
}
}
else
Console.WriteLine("Введите корректное пространство для вычесления !");