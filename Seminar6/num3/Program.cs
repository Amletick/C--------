/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

void Fibonachi(int n)
{
    int fib1=0;
    int fib2=1;
    if (n==1)
    {
        Console.WriteLine(fib1);
    }
    else if (n==2)
    {
        Console.WriteLine(fib1+" "+ fib2);
    }
    else
    {
        int fibcurrent=fib2+fib1;
        Console.Write(fib1+" "+ fib2+" ");
       for (int i=3;i<=n;i++)
    {
        Console.Write(fibcurrent+" ");
        fib1=fib2;
        fib2=fibcurrent;
        fibcurrent=fib2+fib1;
    } 
    }   
}
Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
Fibonachi(n);

