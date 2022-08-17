// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти плоской системы координат: ");
int  numberPlace= int.Parse (Console.ReadLine());
if (numberPlace<5 && numberPlace>0)
{
if (numberPlace == 1)
{
    Console.WriteLine("Диапазон возможных координат: x>0 и y>0");
}
if (numberPlace == 2)
{
    Console.WriteLine("Диапазон возможных координат: x<0 и y>0");
}
if (numberPlace == 3)
{
    Console.WriteLine("Диапазон возможных координат: x<0 и y<0");
}
if (numberPlace == 4)
{
    Console.WriteLine("Диапазон возможных координат: x>0 и y<0");
}
}
else
{
    Console.WriteLine("Введите число от 1 до 4 включительно");
}