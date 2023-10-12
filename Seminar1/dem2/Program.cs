Console.WriteLine("Введите число 1");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2=Convert.ToInt32(Console.ReadLine());
int sqr1=num1*num1;
int sqr2=num2*num2;
if  ((num1==sqr2)|(num2==sqr1))
{
    Console.WriteLine("Одно число квадрат другого");    
}
else
{
    Console.WriteLine("Числа не являются квадратом друг друга");    
}
