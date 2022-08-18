// Определить количество цифр в числе
Console.Write("Введите положительное число: ");
int UserNumber = int.Parse(Console.ReadLine());
int count = 0;
int UserSecondNumber = UserNumber;
while (UserSecondNumber>0)
{
    UserSecondNumber=UserSecondNumber/10;
    count++;
}
Console.WriteLine("Количество цифр в числе " +UserNumber+ " равно " +count);