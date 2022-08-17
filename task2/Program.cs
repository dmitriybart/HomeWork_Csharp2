// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
double firstNumber = double.Parse  (Console.ReadLine());

Console.Write("Введите второе число: ");
double twoNumber = double.Parse (Console.ReadLine());

if (twoNumber*twoNumber==firstNumber)
{
    Console.WriteLine("Первое число - " + firstNumber + ", это квадрат второго - " + twoNumber);
}
else
{
    Console.WriteLine("Первое число - " + firstNumber + ", это НЕ квадрат второго числа - " + twoNumber  );
}
