// Определить количество цифр в числе
Console.Write("Введите положительное число: ");
int UserNumber = int.Parse(Console.ReadLine());
if (UserNumber<100000000)
{
if (UserNumber>=0 && UserNumber<=9)
{
    Console.WriteLine("Число " +UserNumber+ " - однозначное !");
}if (UserNumber>=10 && UserNumber<=99)
{
    Console.WriteLine("Число " +UserNumber+ " - двухзначное !");
}
if (UserNumber>=100 && UserNumber<=999)
{
    Console.WriteLine("Число " +UserNumber+ " - трехзначное !");
}
if (UserNumber>=1000 && UserNumber<=9999)
{
    Console.WriteLine("Число " +UserNumber+ " - четырехзначное !");
}
if (UserNumber>=10000 && UserNumber<=99999)
{
    Console.WriteLine("Число " +UserNumber+ " - пятизначное !");
}
if (UserNumber>=100000 && UserNumber<=999999)
{
    Console.WriteLine("Число " +UserNumber+ " - шестизначное !");
}
if (UserNumber>=1000000 && UserNumber<=9999999)
{
    Console.WriteLine("Число " +UserNumber+ " - семизначное !");
}
}
else 
{
    Console.WriteLine("Введите подалуйста число по-меньше))");
}