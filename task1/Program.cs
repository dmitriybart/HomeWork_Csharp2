// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели: ");
int NumberWeek = int.Parse(Console.ReadLine());
if (NumberWeek == 6 | NumberWeek == 7)
{
    Console.WriteLine("Этот день выходной !");
}
else 
{
    Console.WriteLine("Этот день НЕ выходной !");
}