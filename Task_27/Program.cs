// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
System.Console.WriteLine("Введите целое число ");
int numA = Convert.ToInt32(Console.ReadLine());
int sum=0;
while (numA!=0)
{
    int numB=numA%10;
    numA=numA/10;
    sum=sum+numB;
}
System.Console.WriteLine($"Сумма чисел в числе {sum}");
