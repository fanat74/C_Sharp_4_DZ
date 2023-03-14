// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число. Число должно быть натуральным");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB>0)
{
int resultOfDegree = ResultOfDegree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {resultOfDegree}");
}
else 
Console.WriteLine("Введите число еще раз. Число должно быть натуральным");

int ResultOfDegree (int x, int y)
{
    int index = x;
for(int i=1; i<y; i++)
{
    x=x*index;
}
return x;
}