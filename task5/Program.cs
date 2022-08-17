// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;

while(count <= n);
{
    Console.WriteLine(count*count*count);
    count++;
}