// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int SumOfDigits (int x)
{
    int sum=0;
    while(x!=0)
    {
        sum=sum+(x%10);
        x=x/10;
    }
return (sum>0 ? sum : sum*(-1));
}

int sumOfDigits=SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumOfDigits}");