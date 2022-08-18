// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
int UserNumber = int.Parse(Console.ReadLine());
int OstUserNumber = UserNumber%10;
if (OstUserNumber%2==0)
{
    int result = UserNumber*UserNumber*UserNumber;
    Console.WriteLine("куб числа " +UserNumber+ " равно "+result);
}
else
{
    Console.WriteLine("Число заканчивается на нечётное число !");
}