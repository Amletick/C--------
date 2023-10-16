/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8 */

int number= new Random().Next(10,100);
Console.WriteLine("Число: "+number);
int max= number%10;
if ((number/10)>max)
{
    max=number/10;
}
Console.WriteLine("Наибольшая цифра: "+max);