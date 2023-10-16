/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

string numstr= Console.ReadLine();
int num= Convert.ToInt32(numstr);
if (100<=num<=999)
{
    int second=(num/10)%10;
    Console.WriteLine(second); 
}

Console.WriteLine("Число не трехзначно");