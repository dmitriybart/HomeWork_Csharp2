// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int UserNumber = int.Parse(Console.ReadLine());
int sum = 1;
int UserSecondNumber = UserNumber;
int UserThreeNumber = 0;
while (UserSecondNumber>0)
{
    UserThreeNumber=UserSecondNumber%10;
    sum=sum*UserThreeNumber;
    UserSecondNumber=UserSecondNumber/10;
}
Console.WriteLine("Сумма цифр в числе " +UserNumber+ " равно " +sum);