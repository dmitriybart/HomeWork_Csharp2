// Найти сумму чисел от 1 до А
Console.Write("Введите число: ");
int UserNumber = int.Parse (Console.ReadLine());
int count = 1;
int sum =0;
while (count<=UserNumber)
{
    sum=sum+count;
    count++;
}

Console.Write("Сумма чисел от 1 до " +UserNumber+ " равна " + sum);